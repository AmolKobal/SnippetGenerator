
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SnippetGenerator.Classes;
using SnippetGenerator.Forms;
using System.IO;

namespace SnippetGenerator
{
    public partial class SnippetGenerator : Form
    {
        #region [ Fields ]
        private FileStatusType mFileStatus = FileStatusType.Saved;
        private string strFileName = string.Empty;
        private string strFilePath = string.Empty;
        //private Boolean bApplyingColor = false;
        private string strCodeSnippet = string.Empty;
        private Int32 intCodeSnippetStart = 0;

        private Int32 intFileCount = 0;

        List<string> mlstReferenceMembers = new List<string>();
        List<string> mlstReferenceMembersType = new List<string>();
        List<string> mlstValueMembers = new List<string>();
        List<string> mlstValueMembersType = new List<string>();
        #endregion

        public SnippetGenerator()
        {
            InitializeComponent();
        }

        private void insertMenuItem_DropDownOpening(object sender, EventArgs e)
        {

        }

        #region [ OpenFile_Click ]
        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = ".cs";
            openFile.Filter = "C# source files(*.cs)|*.cs|" +
                              "VB.NET source files(*.vb)|*.vb|" +
                              "All Files(*.*)|*.*";
            if (DialogResult.OK == openFile.ShowDialog())
            {
                try
                {
                    OpenFile(openFile.FileName);
                    rtbClassGenerator.SelectionStart = rtbClassGenerator.TextLength;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region [ OpenFile ]
        private void OpenFile(string fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);
            switch (fileInfo.Extension)
            {
                case ".rtf":
                    rtbClassGenerator.LoadFile(fileName, RichTextBoxStreamType.RichText);
                    break;
                case ".doc":
                    rtbClassGenerator.LoadFile(fileName, RichTextBoxStreamType.RichText);
                    break;
                default:
                    rtbClassGenerator.LoadFile(fileName, RichTextBoxStreamType.PlainText);
                    break;
            }            
            this.strFilePath = fileName;
            this.strFileName = fileInfo.Name;
            this.Text = "ClassGenerator - " + fileInfo.Name;

            ParseFile();
        }
        #endregion

        #region [ ParseFile ]
        private void ParseFile()
        {
            statusGenerator.Text = string.Empty;
            statusGenerator.ForeColor = Color.Black;
            if(rtbClassGenerator.TextLength < 0)
            {
                mlstReferenceMembers.Clear();
                mlstReferenceMembersType.Clear();
                mlstValueMembers.Clear();
                mlstValueMembersType.Clear();
                return;
            }
            try
            {
                mlstReferenceMembers.Clear();
                mlstReferenceMembersType.Clear();
                mlstValueMembers.Clear();
                mlstValueMembersType.Clear();

                string[] separators = {"+", "*", "\\", "%", "^", "-", " ", "/", "<", ">", "+=", "++", "--",
                                    "-=", "*=", "/=", "%=", "<<=", ">>=", "<<", ">>", "&=", "&", "!", "|",
                                    "|=", "~","&&", "||", ".*", "->", "::", "(", ")", "[", "]", "?", "!=",
                                    "==", "", ";","{", "}", "\r", "\n", "\t"};

                // Split text into tokens.
                string[] strTokens = rtbClassGenerator.Text.Split(separators, System.StringSplitOptions.RemoveEmptyEntries);
                for (Int32 index = 0; index < strTokens.Length; index++)
                {
                    if (strTokens.Length > (index + 1))
                    {
                        switch (strTokens[index])
                        {
                            #region [ class ]
                            case "class":
                                if (!ContainsReferenceType(strTokens[index + 1]))
                                {
                                    if (!ContainseValueType(strTokens[index + 1]))
                                    {
                                        mlstReferenceMembers.Add(strTokens[index + 1]);
                                        mlstReferenceMembersType.Add("class");                                        
                                    }
                                    else
                                    {
                                        statusGenerator.Text = "CS0101:" + strFileName +
                                                               " already contains definition for '" +
                                                               strTokens[index + 1] + "' as " +
                                                               GetValueType(strTokens[index + 1]);
                                        statusGenerator.ForeColor = Color.Red;
                                    }

                                }
                                else
                                {
                                    statusGenerator.Text = "Class '" + strTokens[index + 1] +
                                                           "' already defined.";
                                    statusGenerator.ForeColor = Color.Red;
                                }
                                break;
                            #endregion

                            #region [ struct ]
                            case "struct":
                                if (!ContainseValueType(strTokens[index + 1]))
                                {
                                    if (!ContainsReferenceType(strTokens[index + 1]))
                                    {
                                        mlstValueMembers.Add(strTokens[index + 1]);
                                        mlstValueMembersType.Add("struct");                                        
                                    }
                                    else
                                    {
                                        statusGenerator.Text = "CS0101:" + strFileName +
                                                               " already contains definition for '" +
                                                               strTokens[index + 1] + "' as " +
                                                               GetReferenceType(strTokens[index + 1]);
                                        statusGenerator.ForeColor = Color.Red;
                                    }
                                }
                                else
                                {
                                    statusGenerator.Text = "Struct '" + strTokens[index + 1] +
                                                           "' already defined.";
                                    statusGenerator.ForeColor = Color.Red;
                                }
                                break;
                            #endregion

                            #region [ interface ]
                            case "interface":
                                if (!ContainsReferenceType(strTokens[index + 1]))
                                {
                                    if (!ContainseValueType(strTokens[index + 1]))
                                    {
                                        mlstReferenceMembers.Add(strTokens[index + 1]);
                                        mlstReferenceMembersType.Add("interface");
                                    }
                                    else
                                    {
                                        statusGenerator.Text = "CS0101:" + strFileName +
                                                               " already contains definition for '" +
                                                               strTokens[index + 1] + "' as " +
                                                               GetValueType(strTokens[index + 1]);
                                        statusGenerator.ForeColor = Color.Red;
                                    }
                                }
                                else
                                {
                                    statusGenerator.Text = "Interface '" + strTokens[index + 1] +
                                                           "' already defined.";
                                    statusGenerator.ForeColor = Color.Red;
                                }
                                break;
                            #endregion

                            #region [ delegate ]
                            case "delegate":
                                if ((strTokens.Length + 1 > (index + 1)) &&
                                !ContainsReferenceType(strTokens[index + 2]))
                                {
                                    if (!ContainseValueType(strTokens[index + 2]))
                                    {
                                        mlstReferenceMembers.Add(strTokens[index + 2]);
                                        mlstReferenceMembersType.Add("delegate");                                        
                                    }
                                    else
                                    {
                                        statusGenerator.Text = "CS0101:" + strFileName +
                                                               " already contains definition for '" +
                                                               strTokens[index + 2] + "' as " +
                                                               GetValueType(strTokens[index + 1]);
                                        statusGenerator.ForeColor = Color.Red;
                                    }
                                }
                                else
                                {
                                    statusGenerator.Text = "Delegate '" + strTokens[index + 2] +
                                                           "' already defined.";
                                    statusGenerator.ForeColor = Color.Red;
                                }
                                break;
                            #endregion

                            #region [ enum ]
                            case "enum":
                                if (!ContainseValueType(strTokens[index + 1]))
                                {
                                    if (!ContainsReferenceType(strTokens[index + 1]))
                                    {
                                        mlstValueMembers.Add(strTokens[index + 1]);
                                        mlstValueMembersType.Add("enum");                                        
                                    }
                                    else
                                    {
                                        statusGenerator.Text = "CS0101:" + strFileName +
                                                               " already contains definition for '" +
                                                               strTokens[index + 1] + "' as " +
                                                               GetReferenceType(strTokens[index + 1]);
                                        statusGenerator.ForeColor = Color.Red;
                                    }
                                }
                                else
                                {
                                    statusGenerator.Text = "Enum '" + strTokens[index + 1] +
                                                           "' already exists.";
                                    statusGenerator.ForeColor = Color.Red;
                                }
                                break;
                            #endregion
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region [ NewFile_Click ]
        private void NewFile_Click(object sender, EventArgs e)
        {
            NewFile();
        }
        #endregion

        #region [ NewFile ]
        private void NewFile()
        {
            DialogResult reply = AskFileSave();
            if (DialogResult.Cancel != reply)
            {
                this.strFileName = string.Empty;
                this.mFileStatus = FileStatusType.Saved;

                rtbClassGenerator.Text = string.Empty;
                rtbClassGenerator.ClearUndo();
                this.strFilePath = string.Empty;
                intFileCount++;
                this.strFileName = "file" + intFileCount;
                this.Text = "ClassGenerator - " + strFileName;
            }
        }
        #endregion

        #region [ AskFileSave ]
        private DialogResult AskFileSave()
        {
            DialogResult reply = DialogResult.No;
            if (this.mFileStatus == FileStatusType.Notsaved)
            {
                reply = MessageBox.Show("The contents of file '" + strFileName + "' are not saved.\n" +
                                        "Do you want to save contents.", "Save", MessageBoxButtons.YesNoCancel,
                                        MessageBoxIcon.Question);
                if (DialogResult.Yes == reply)
                    SaveFile();
            }
            return reply;
        }
        #endregion

        #region [ GetFileName ]
        private string GetFileName()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "C# source files(*.cs)|*.cs|" +
                              "VB.NET source files(*.vb)|*.vb|" +
                              "All Files(*.*)|*.*";
            if (DialogResult.OK == saveFile.ShowDialog())
                return saveFile.FileName;
            return string.Empty;
        }
        #endregion

        #region [ InsertClass ]
        private void InsertClass(object sender, EventArgs e)
        {
            frmClass Class = new frmClass();
            if (DialogResult.OK == Class.ShowDialog())
            {
                if (!ContainsReferenceType(Class.ClassName))
                {
                    rtbClassGenerator.SelectedText = Class.Class;
                    mlstReferenceMembers.Add(Class.ClassName);
                }
                else
                    MessageBox.Show("Class '" + Class.ClassName + "' already added.");
            }
            Class.Close();
        }
        #endregion

        #region [ ContainsReferenceType ]
        private bool ContainsReferenceType(string referenceName)
        {
            if (mlstReferenceMembers.Contains(referenceName))
                return true;
            return false;
        }
        #endregion

        #region [ GetReferenceType ]
        private string GetReferenceType(string referenceName)
        {
            for (Int32 index = 0; index < mlstReferenceMembers.Count; index++)
            {
                if (mlstReferenceMembers[index].Equals(referenceName))
                    return mlstReferenceMembersType[index];
            }
            return string.Empty;
        }
        #endregion

        #region [ GetValueType ]
        private string GetValueType(string valueName)
        {
            for (Int32 index = 0; index < mlstValueMembers.Count; index++)
            {
                if (mlstValueMembers.Equals(valueName))
                    return mlstValueMembersType[index];
            }
            return string.Empty;
        }
        #endregion

        #region [ ContainseValueType ]
        private bool ContainseValueType(string valueName)
        {
            if (mlstValueMembers.Contains(valueName))
                return true;
            return false;
        }
        #endregion

        #region [ InsertNamespace ]
        private void InsertNamespace(object sender, EventArgs e)
        {
            frmNamespace Namespace = new frmNamespace();
            if (DialogResult.OK == Namespace.ShowDialog())
                rtbClassGenerator.SelectedText = Namespace.Namespace;
            Namespace.Close();
        }
        #endregion

        private void RTBClassGenerator_TextChanged(object sender, EventArgs e)
        {
            this.mFileStatus = FileStatusType.Notsaved;
            ParseFile();
            //if (bApplyingColor) return;
            //    ApplyColorToKeywords();
        }

        #region [ ApplyColorToKeywords ]
        //private void ApplyColorToKeywords()
        //{
        //    if (rtbClassGenerator.Text.Trim().Equals(string.Empty))
        //        return;

        //     Set appplying color falg to true.
        //    bApplyingColor = true;
        //     Desable Rich Textbox.
        //    rtbClassGenerator.Enabled = false;
        //    Int32 intSelectionStart = rtbClassGenerator.SelectionStart;
        //    rtbClassGenerator.SelectionStart = 0;
        //    rtbClassGenerator.SelectionLength = 99999;
        //     Make all text to appear in black.
        //    rtbClassGenerator.SelectionColor = Color.Black;
        //    rtbClassGenerator.SelectionStart = 0;
        //    rtbClassGenerator.SelectionLength = 0;

        //    string[] separators = {"+", "*", "\\", "%", "^", "-", " ", "/", "<", ">", "+=", "++", 
        //                           "--", "-=", "*=", "/=", "%=", "<<=", ">>=", "<<", ">>", "&=",
        //                           "&", "!", "|", "|=", "~", "&&", "||", "(", ")", "[", "]", "?",
        //                           "!=", "==", ":", ";", "{", "}", "\r", "\n", "\t"};

        //     Split text into tokens.
        //    string[] strTokens = rtbClassGenerator.Text.Split(separators, System.StringSplitOptions.RemoveEmptyEntries);

        //    Int32 intIndex = 0;

        //    Int32 intPos = 0;
        //    Int32 intStartPos = 0;
        //    Char ch = '\0';
        //    foreach (string Item in strTokens)
        //    {
        //        intStartPos = 1;
        //        for (intIndex = 0; intIndex < lstCPPKeywords.Items.Count; intIndex++)
        //        {
        //             if( item is keyword.
        //            if (Item.Equals(lstCPPKeywords.Items[intIndex]))
        //            {
        //                intPos = 1;
        //                do
        //                {
        //                     Find item in text.
        //                    intPos = rtbClassGenerator.Text.IndexOf(Item, intStartPos);
        //                     Item found in text.
        //                    if (intIndex > 0 && intIndex < rtbClassGenerator.TextLength)
        //                        ch = rtbClassGenerator.Text[intIndex - 1];
        //                    if (intPos >= 0 && intIndex > 0 && (ch == ' ' || ch == '\n' || ch == '\r'))
        //                    {
        //                        intStartPos = intPos + Item.Length;
        //                        rtbClassGenerator.SelectionStart = intPos; // intPos - 1;
        //                        rtbClassGenerator.SelectionLength = Item.Length;
        //                    }
        //                     Apply color to item.
        //                    switch (Item)
        //                    {
        //                        case "#if":
        //                            rtbClassGenerator.SelectionColor = Color.DeepPink;
        //                            break;
        //                        case "#else":
        //                            rtbClassGenerator.SelectionColor = Color.DeepPink;
        //                            break;
        //                        case "#elif":
        //                            rtbClassGenerator.SelectionColor = Color.DeepPink;
        //                            break;
        //                        case "#endif":
        //                            rtbClassGenerator.SelectionColor = Color.DeepPink;
        //                            break;
        //                        case "#define":
        //                            rtbClassGenerator.SelectionColor = Color.DeepPink;
        //                            break;
        //                        case "#undef":
        //                            rtbClassGenerator.SelectionColor = Color.DeepPink;
        //                            break;
        //                        case "#warning":
        //                            rtbClassGenerator.SelectionColor = Color.DeepPink;
        //                            break;
        //                        case "#error":
        //                            rtbClassGenerator.SelectionColor = Color.DeepPink;
        //                            break;
        //                        case "#line":
        //                            rtbClassGenerator.SelectionColor = Color.DeepPink;
        //                            break;
        //                        case "#region":
        //                            rtbClassGenerator.SelectionColor = Color.DeepPink;
        //                            break;
        //                        case "#endregion":
        //                            rtbClassGenerator.SelectionColor = Color.DeepPink;
        //                            break;
        //                        case "#pragma":
        //                            rtbClassGenerator.SelectionColor = Color.DeepPink;
        //                            break;
        //                        case "#pragma warning":
        //                            rtbClassGenerator.SelectionColor = Color.DeepPink;
        //                            break;
        //                        case "#pragma checksum":
        //                            rtbClassGenerator.SelectionColor = Color.DeepPink;
        //                            break;
        //                        default:
        //                            rtbClassGenerator.SelectionColor = Color.Blue;
        //                            break;
        //                    }
        //                }
        //                while (intPos > 0);
        //            }
        //        }
        //    }

        //    rtbClassGenerator.SelectionStart = intSelectionStart;
        //    rtbClassGenerator.SelectionLength = 0;
        //     Enable Rich Textbox.
        //    rtbClassGenerator.Enabled = true;
        //    rtbClassGenerator.Focus();
        //     Reset applying color flag to false.
        //    bApplyingColor = false;

        //    rtbClassGenerator.GetFirstCharIndexOfCurrentLine();
        //    rtbClassGenerator.GetLineFromCharIndex(rtbClassGenerator.SelectionStart);

        //}
        #endregion

        #region [ ClassGenerator_Load ]
        private void ClassGenerator_Load(object sender, EventArgs e)
        {
            rtbClassGenerator.Text = "\n";
            EnableEditMenuItem();
            intFileCount++;
            strFileName = "file" + intFileCount;
            this.Text = "ClassGenerator - " + strFileName;
        }
        #endregion

        #region [ InsertInterface ]
        private void InsertInterface(object sender, EventArgs e)
        {
            frmInterface Interface = new frmInterface();
            if (DialogResult.OK == Interface.ShowDialog())
            {
                if (!ContainsReferenceType(Interface.InterfaceName))
                {
                    this.rtbClassGenerator.SelectedText = Interface.Interface;
                    mlstReferenceMembers.Add(Interface.InterfaceName);
                }
                else
                    MessageBox.Show("Interface '" + Interface.InterfaceName + "' already added.");
            }
            Interface.Close();
        }
        #endregion

        #region [ rtbClassGenerator_SelectionChanged ]
        private void rtbClassGenerator_SelectionChanged(object sender, EventArgs e)
        {
            cutToolbarButton.Enabled = rtbClassGenerator.SelectionLength > 0 ? true : false;
            copyToolbarButton.Enabled = cutToolbarButton.Enabled;
            

            pasteToolbarButton.Enabled = rtbClassGenerator.CanPaste(DataFormats.GetFormat(DataFormats.Text));

            undoToolbarButton.Enabled = rtbClassGenerator.CanUndo;
            redoToolbarButton.Enabled = rtbClassGenerator.CanRedo;
        }
        #endregion

        private void EditMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            EnableEditMenuItem();
        }

        #region [ EnableEditMenuItem ]
        private void EnableEditMenuItem()
        {
            cutToolbarButton.Enabled = rtbClassGenerator.SelectionLength > 0 ? true : false;
            copyToolbarButton.Enabled = cutToolbarButton.Enabled;
            clearEditMenuItem.Enabled = cutToolbarButton.Enabled;

            cutEditMenuItem.Enabled = cutToolbarButton.Enabled;
            copyEditMenuItem.Enabled = cutToolbarButton.Enabled; 

            pasteToolbarButton.Enabled = rtbClassGenerator.CanPaste(DataFormats.GetFormat(DataFormats.Text));

            selectAllEditMenuItem.Enabled = rtbClassGenerator.TextLength > 0 ? true : false;

            undoEditMenuItem.Enabled = rtbClassGenerator.CanUndo;
            redoEditMenuItem.Enabled = rtbClassGenerator.CanRedo;
        }
        #endregion

        private void Paste(object sender, EventArgs e)
        {
            rtbClassGenerator.Paste(DataFormats.GetFormat(DataFormats.Text));
        }

        private void Copy(object sender, EventArgs e)
        {
            rtbClassGenerator.Copy();
        }

        private void Cut(object sender, EventArgs e)
        {
            rtbClassGenerator.Cut();
        }

        #region [ InsertField ]
        private void InsertField(object sender, EventArgs e)
        {
            frmField Field = new frmField();
            if (DialogResult.OK == Field.ShowDialog())
            {
                rtbClassGenerator.SelectedText = Field.Field;
            }
            Field.Close();
        }
        #endregion

        #region [ InsertProperty ]
        private void InsertProperty(object sender, EventArgs e)
        {
            frmProperty Property = new frmProperty();
            if (DialogResult.OK == Property.ShowDialog())
            {
                rtbClassGenerator.SelectedText = Property.Property;
            }
            Property.Close();
        }
        #endregion

        #region [ InsertStructure ]
        private void InsertStructure(object sender, EventArgs e)
        {
            frmStruct Struct = new frmStruct();
            if (DialogResult.OK == Struct.ShowDialog())
            {
                if (!ContainseValueType(Struct.StructName))
                {
                    rtbClassGenerator.SelectedText = Struct.Struct;
                    mlstValueMembers.Add(Struct.StructName);
                }
                else
                    MessageBox.Show("Struct '" + Struct.StructName + "' already added.");
            }
            Struct.Close();
        }
        #endregion

        #region [ InsertConstant ]
        private void InsertConstant(object sender, EventArgs e)
        {
            frmConstant Constant = new frmConstant();
            if (DialogResult.OK == Constant.ShowDialog())
                rtbClassGenerator.SelectedText = Constant.Constants;
            Constant.Close();
        }
        #endregion

        #region [ InsertEnumeration ]
        private void InsertEnumeration(object sender, EventArgs e)
        {
            frmEnumeration Enum = new frmEnumeration();
            if (DialogResult.OK == Enum.ShowDialog())
            {
                if (!ContainseValueType(Enum.EnumName))
                {
                    rtbClassGenerator.SelectedText = Enum.Enum;
                    mlstValueMembers.Add(Enum.EnumName);
                }
                else
                    MessageBox.Show("Enum '" + Enum.EnumName + "' already added.");
            }
            Enum.Close();
        }
        #endregion

        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region [ ViewReferenceTypes ]
        private void ViewReferenceTypes(object sender, EventArgs e)
        {
            frmReferenceType ReferenceType = new frmReferenceType();
            ReferenceType.MembersType = this.mlstReferenceMembersType;
            ReferenceType.Members = mlstReferenceMembers;
            ReferenceType.ShowDialog(this);
            ReferenceType.Close();
        }
        #endregion

        #region [ ViewValueTypes ]
        private void ViewValueTypes(object sender, EventArgs e)
        {
            frmValueType ValueType = new frmValueType();
            ValueType.MembersType = mlstValueMembersType;
            ValueType.Members = mlstValueMembers;
            ValueType.ShowDialog(this);
            ValueType.Close();
        }
        #endregion

        #region [ InsertDelegate ]
        private void InsertDelegate(object sender, EventArgs e)
        {
            frmDelegate Delegate = new frmDelegate();
            if (DialogResult.OK == Delegate.ShowDialog())
            {
                if (!ContainsReferenceType(Delegate.DelegateName))
                {
                    rtbClassGenerator.SelectedText = Delegate.Delegate;
                    mlstReferenceMembers.Add(Delegate.DelegateName);
                }
                else
                    MessageBox.Show("Delegate '" + Delegate.DelegateName + "' already added.");
            }
            Delegate.Close();
        }
        #endregion

        private void Undo(object sender, EventArgs e)
        {
            rtbClassGenerator.Undo();
        }

        private void Redo(object sender, EventArgs e)
        {
            rtbClassGenerator.Redo();
        }

        private void Clear(object sender, EventArgs e)
        {
            rtbClassGenerator.SelectedText = string.Empty;
        }

        private void SelectAll(object sender, EventArgs e)
        {
            rtbClassGenerator.SelectionStart = 0;
            rtbClassGenerator.SelectionLength = rtbClassGenerator.TextLength;
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        #region [ SaveFile ]
        private void SaveFile()
        {
            if (strFilePath.Equals(String.Empty))
                strFilePath = GetFileName();
            if (!strFilePath.Equals(string.Empty))
            {
                FileInfo fileInfo = new FileInfo(strFilePath);
                this.strFileName = fileInfo.Name;
                this.Text = "ClassGenerator - " + strFileName;
                rtbClassGenerator.SaveFile(strFileName, RichTextBoxStreamType.PlainText);
                this.mFileStatus = FileStatusType.Saved;
            }
        }
        #endregion

        private void CloseFile(object sender, EventArgs e)
        {
            NewFile();
        }

        #region  [ InsertDefaultConstructor]
        private void InsertDefaultConstructor(object sender, EventArgs e)
        {
            string strClassName = GetClassName();
            rtbClassGenerator.SelectedText = "public " + strClassName + "()\n\t{\n\t}";
        }
        #endregion

        #region [ GetClassName ]
        private string GetClassName()
        {
            Int32 intStartIndex = 0;
            Int32 intFoundIndex = -1;
            string strClassName = string.Empty;
            do
            {
                intFoundIndex = rtbClassGenerator.Text.IndexOf("class", intStartIndex);
                if (intFoundIndex != -1 && intFoundIndex < rtbClassGenerator.SelectionStart)
                {
                    intStartIndex = intFoundIndex + "class".Length;
                    Int32 ch = 0;
                    Int32 length = 0;
                    for (Int32 index = intStartIndex + 1; index < rtbClassGenerator.SelectionStart; index++, length++)
                    {
                        ch = Convert.ToInt32(rtbClassGenerator.Text[index]);
                        if ((ch >= 48 && ch < 57) || (ch >= 65 && ch <= 90) || (ch >= 97 && ch <= 122) || ch == '_')
                            continue;
                        else
                            break;
                    }
                    strClassName = rtbClassGenerator.Text.Substring(intStartIndex + 1, length);
                    intStartIndex += strClassName.Length + 1;
                }
                else
                    break;
            }
            while (intStartIndex < rtbClassGenerator.SelectionStart && intFoundIndex != -1);
            return strClassName;
        }
        #endregion

        #region [ ParameterizedConstructor ]
        private void ParameterizedConstructor(object sender, EventArgs e)
        {
            frmParameterizedConstructor ParameterizedConstructor = new frmParameterizedConstructor();
            ParameterizedConstructor.ClassName = GetClassName();
            if (DialogResult.OK == ParameterizedConstructor.ShowDialog(this))
                rtbClassGenerator.SelectedText = ParameterizedConstructor.Constructor;
            ParameterizedConstructor.Close();
        }
        #endregion

        #region [ rtbContextMenuStrip_Opening ]
        private void rtbContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            cutContextMenuItem.Enabled = rtbClassGenerator.SelectionLength > 0 ? true : false;
            copyContextMenuItem.Enabled = cutContextMenuItem.Enabled;
            clearContextMenuItem.Enabled = cutContextMenuItem.Enabled;

            undoContextMenuItem.Enabled = rtbClassGenerator.CanUndo;
            redoContextMenuItem.Enabled = rtbClassGenerator.CanRedo;

            pasteContextMenuItem.Enabled = rtbClassGenerator.CanPaste(DataFormats.GetFormat(DataFormats.Text));
        }
        #endregion

        #region [ InsertCodeSnippet ]
        private void InsertCodeSnippet(object sender, EventArgs e)
        {
            frmInsertcodeSnippetEditor CodeSnippet = new frmInsertcodeSnippetEditor();
            if (DialogResult.OK == CodeSnippet.ShowDialog(this))
                rtbClassGenerator.SelectedText = CodeSnippet.CodeSnippet;
            CodeSnippet.Close();
        }
        #endregion

        private void ClassGenerator_SizeChanged(object sender, EventArgs e)
        {
            rtbClassGenerator.Size = new Size(this.ClientRectangle.Width,
                this.ClientRectangle.Height - statusbarGenerator.Height - rtbClassGenerator.Top);
        }

        private void Print(object sender, EventArgs e)
        {

        }

        private void rtbClassGenerator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Space)
            {
                Point location = rtbClassGenerator.GetPositionFromCharIndex(rtbClassGenerator.SelectionStart);
                lstCodeSnippet.Location = new Point(location.X + rtbClassGenerator.Location.X,
                                                    location.Y + rtbClassGenerator.Location.Y + rtbClassGenerator.Font.Height);
                lstCodeSnippet.Visible = true;
                lstCodeSnippet.SelectedIndex = 0;
                intCodeSnippetStart = rtbClassGenerator.SelectionStart;
                return;
            }
            if (lstCodeSnippet.Visible)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        if (lstCodeSnippet.SelectedIndex > 0)
                            lstCodeSnippet.SelectedIndex -= 1;
                        e.Handled = true;
                        break;
                    case Keys.Down:
                        if (lstCodeSnippet.SelectedIndex < lstCodeSnippet.Items.Count - 1)
                            lstCodeSnippet.SelectedIndex += 1;
                        e.Handled = true;
                        break;
                    case Keys.Left:
                        lstCodeSnippet.Visible = false;
                        e.Handled = true;
                        break;
                    case Keys.Right:
                        lstCodeSnippet.Visible = false;
                        e.Handled = true;
                        break;
                    case Keys.Escape:
                        lstCodeSnippet.Visible = false;
                        e.Handled = true;
                        break;
                    case Keys.Back:
                        if (rtbClassGenerator.SelectionStart < intCodeSnippetStart)
                            lstCodeSnippet.Visible = false;
                        break;
                    default:                        
                        break;
                }
            }
        }

        private void lstCodeSnippet_DoubleClick(object sender, EventArgs e)
        {
            frmInsertcodeSnippetEditor CodeSnippet = new frmInsertcodeSnippetEditor();
            rtbClassGenerator.SelectionStart = intCodeSnippetStart;
            try
            {
                rtbClassGenerator.SelectionLength = rtbClassGenerator.SelectionStart - intCodeSnippetStart;
            }
            catch
            {
            }
            rtbClassGenerator.SelectedText = CodeSnippet[lstCodeSnippet.SelectedIndex];
            CodeSnippet.Close();
            lstCodeSnippet.Visible = false;
        }

        private void rtbClassGenerator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lstCodeSnippet.Visible)
                if ((Int32)Keys.Enter == Convert.ToInt32(e.KeyChar))
                    lstCodeSnippet_DoubleClick(lstCodeSnippet, new EventArgs());
        }

        private void rtbClassGenerator_KeyUp(object sender, KeyEventArgs e)
        {
            if (lstCodeSnippet.Visible)
                if ((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) ||
                    (Keys.NumPad0 <= e.KeyCode && Keys.NumPad9 >= e.KeyCode) ||
                    (Keys.D0 <= e.KeyCode && Keys.D9 >= e.KeyCode))
                {
                    strCodeSnippet = rtbClassGenerator.Text.Substring(intCodeSnippetStart,
                                    rtbClassGenerator.SelectionStart - intCodeSnippetStart).Trim();
                    lstCodeSnippet.SelectedIndex = lstCodeSnippet.FindString(strCodeSnippet);
                }
        }
    }
}