using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class NameDialog
    {
        public static DialogResult InputBox(ref string player1Name, ref string player2Name)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox1 = new TextBox();
            TextBox textBox2 = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = "Player names";
            textBox1.Text = "Player 1";
            textBox2.Text = "Player 2";

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox1.SetBounds(12, 36, 372, 20);
            textBox2.SetBounds(12, 65, 372, 20);
            buttonOk.SetBounds(228, 110, 75, 23);
            buttonCancel.SetBounds(309, 110, 75, 23);

            label.AutoSize = true;
            textBox1.Anchor = textBox1.Anchor | AnchorStyles.Right;
            textBox2.Anchor = textBox1.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 150);
            form.Controls.AddRange(new Control[] { label, textBox1,textBox2, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(200, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            DialogResult dialogResult = form.ShowDialog();

            player1Name = textBox1.Text;
            player2Name = textBox2.Text;
            return dialogResult;
        }
    }
}
