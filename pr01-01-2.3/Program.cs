using System;

namespace pr01_01_2._3
{
  class Program
  {
    static void Main(string[] args)
    {
      // C#
      try
      {
        TextReader tr = new StreamReader(locationTextBox.Text);
        try
        { displayTextBox.Text = tr.ReadToEnd(); }
        catch (Exception ex)
        { MessageBox.Show(ex.Message); }
        finally
        { tr.Close(); }
      }
      catch (Exception ex)
      { MessageBox.Show(ex.Message); }
      // C#
      try
      {
        TextReader tr = new StreamReader(locationTextBox.Text); try
        { displayTextBox.Text = tr.ReadToEndO; }
        catch (Exception ex)
        { MessageBox.Show(ex.Message); }
        finally
        { tr.Close(); }
      }
      catch (System.IO.FileNotFoundException ex)
      { MessageBox.Show("Sorry, the file does not exist."); }
      catch (System.UnauthorizedAccessException ex)
      { MessageBox.Show("Sorry, you lack sufficient privileges."); }
      catch (Exception ex)
      { MessageBox.Show(ex.Message); }
    }
  }
}
