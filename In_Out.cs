class In_Out{
   /*
   A code template for a computer console. The responsibility of this 
   class of objects is to get text or numerical input and display text output.

   Attributes:
      prompt (string): The prompt to display on each line.
   */

   /*
   Gets the text input from the user through the screen

   Retruns:
      string: the user's input as text
   */
   public string Read(){
      string input = Console.ReadLine();
      return input;
   }

   /*
   Gets numerical input from the user through the screen

   Returns:
      float: The uer's input as a float
   */
   public int ReadNumber(string prompt){
      Console.Write(prompt);
      int input = Convert.ToInt32(Console.ReadLine());
      return input;
   }

   // Displays the given text on the screen
   public void Write(string text){
      Console.WriteLine(text);
   }
}