class Director{
   /*
   A code template for a person who directs the game. The responsibility of 
   this class of objects is to control the sequence of play.

   Attributes:
         console (Console): An instance of the class of objects known as Console.
         keepPlaying (boolean): Whether or not the game can continue.
         seeker (Seeker): An instance of the class of objects known as Seeker.
         hider (Hider): An instance of the class of objects known as Hider.
   */

   In_Out in_out;
   Seeker seeker;
   Hider hider;
   bool keepPlaying;

   // The class constructor
   public Director(){
      in_out = new In_Out();
      seeker = new Seeker();
      hider = new Hider();
      keepPlaying = true;
   }

   // Starts the game loop to control the sequence of play
   public void StartGame(){
      while (keepPlaying){
         GetInputs();
         DoUpdates();
         DoOutputs();
      }
   }

   // Gets the inputs at the beginning of each round of play. In this case,
   // that means moving the seker to a new location
   public void GetInputs(){
      string message = seeker.GetMessage();
      Console.WriteLine(message);
      int location = in_out.ReadNumber("Enter a location [1-1000]: ");
      seeker.Move(location);
   }

   // Updates the important game information of each round of play. In
   // this case, that means the hider watches the seeker.
   public void DoUpdates(){
      hider.Watch(seeker.location());
   }

   // Outputs the important game information for each round of play. In
   // this case, that means the hider provides a hint.
   public void DoOutputs(){
      string hint = hider.GetHint();
      in_out.Write(hint);
      keepPlaying = hider.distance[-1] != 0;
   }
}