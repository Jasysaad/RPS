using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperSci
{
	 abstract class  Player
	{
		public string name { get; set; } //recieves and stores name

		public Player(string _name) //sets name
        {
			Name = _name;
        }
		public Player() //incase empty
        {

        }

		public abstract RPS GenerateRPS(); //absratc method to be inherited/overwritten
        

	}

}
