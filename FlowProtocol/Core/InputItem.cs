namespace FlowProtocol.Core
{
   public class InputItem :IElementWithHelpLines
   {
      public string Key { get; set; }
      public string QuestionText { get; set; }
      public List<string> HelpLines { get; set; }

      public InputItem()
      {
         Key = string.Empty;
         QuestionText = string.Empty;
         HelpLines = new List<string>();
      }
      
      // Fügt eine neue Hilfezeile hinzu
      public void AddHelpLine(string helpline)
      {         
         HelpLines.Add(helpline);
      }

      // Wendet eine Text-Operation auf die Text-Bestandteile der Frage an.
      public void ApplyTextOperation(Func<string, string> conv)
      {
         QuestionText = conv(QuestionText);
         HelpLines = CoreLib.ApplyTextOperationToList(HelpLines, conv);
      }

      // Prüft, ob ein String eine URL ist. Wird für die Partial-Views benötigt
      public bool IsURL(string text, out string url, out string displayText)
      {
         return CoreLib.IsURL(text, out url, out displayText);
      }
   }
}