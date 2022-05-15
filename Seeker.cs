class Seeker
{
   /*
   A code template for the seeker who looks for the hider. The
   responsibility of this class of the objects is to move from location to
   location in pursuit of the Hider.

   Attributes:
      location (integer): The location of the Seeker (1-1000).
      distance (list): The distance travelled with each move.
   */

   Random random = new Random();
   List<int> distance;
   int location;

   public Seeker()
   {
      distance = new List<int>();
      location = random.Next(999) + 1;
   }

   /*
   Gets a message from the seeker.
   Returns:
      string: A message from the seeker.
   */
   public string GetMessage()
   {
      string message = "\nI'm going to find you!";
      if (distance[-1] == 0)
      {
         message = "\nI'm going to find you!";
      }
      else if (distance[-1] < distance[-2])
      {
         message = "\nShhh. I'm sneaking in now...";
      }
      else if (distance[-1] > distance[-2])
      {
         message = "\nI'm running around, but I'll find you...";
      }
      return message;
   }

   /*
   Moves to the given loation and keeps track of the distance.
   */
   public void Move(int location)
   {
      int distance = this.location - location;
      this.distance.Add(distance);
      this.location = location;
   }
}