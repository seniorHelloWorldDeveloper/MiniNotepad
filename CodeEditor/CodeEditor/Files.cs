using System.Windows.Forms;
using System.IO;


namespace CodeEditor
{
    public class Files
    {
        public OpenFileDialog opf = new OpenFileDialog();
        
        public void openFile(RichTextBox richTextBox)
        {
            if (this.opf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader streamReader = new StreamReader(opf.FileName))
                    {
                        richTextBox.Text = streamReader.ReadToEnd();
                    }
                }
                catch(FileNotFoundException ex)
                {
                    MessageBox.Show("Ошибка.");
                }
            }
        }

        public void saveFileAs(RichTextBox richTextBox)
        {
            SaveFileDialog svd = new SaveFileDialog();
            if (svd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(svd.FileName))
                    {
                        sw.WriteLine(richTextBox.Text);
                    }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Ошибка.");
                }
            }
        }

        public void saveFile(RichTextBox richTextBox)
        {
            try
            {
                if (opf.FileName != "")
                {
                    using (StreamWriter streamWriter = new StreamWriter(opf.FileName))
                    {
                        streamWriter.WriteLine(richTextBox.Text);
                    }
                }
                else
                {
                    saveFileAs(richTextBox);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Ошибка.");
            }
        }
    }
}
