﻿using Notepad_Light.Helpers;

namespace Notepad_Light.Forms
{
    public partial class FrmPasteUI : Form
    {
        public string SelectedPasteOption = string.Empty;

        public FrmPasteUI()
        {
            InitializeComponent();

            // populate the combo box
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                cboClipFormats.Items.Add(Strings.plainText);
            }

            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                cboClipFormats.Items.Add(Strings.pasteRtf);
            }

            if (Clipboard.ContainsText(TextDataFormat.Html))
            {
                cboClipFormats.Items.Add(Strings.pasteHtml);
            }

            if (Clipboard.ContainsText(TextDataFormat.UnicodeText))
            {
                cboClipFormats.Items.Add(Strings.pasteUnicode);
            }

            if (Clipboard.ContainsImage())
            {
                cboClipFormats.Items.Add(Strings.pasteImage);
            }

            cboClipFormats.SelectedIndex = 0;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            SelectedPasteOption = cboClipFormats.Text;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
