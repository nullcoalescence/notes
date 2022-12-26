namespace notes;

public partial class NotePage : ContentPage
{
	string fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

	public NotePage()
	{
		InitializeComponent();

		if (File.Exists(this.fileName))
		{
			TextEditor.Text = File.ReadAllText(this.fileName);
		}
	}

	private void SaveButton_Clicked(object sender, EventArgs e)
	{
		File.WriteAllText(this.fileName, TextEditor.Text);
	}

	private void DeleteButton_Clicked(object sender, EventArgs e)
	{
		if (File.Exists(this.fileName))
		{
			File.Delete(this.fileName);
		}

		TextEditor.Text = string.Empty;
	}
}