using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperSci
{
	 class RockPlayer:Player
	{
		public string Name { get; set; }
		public RockPlayer()
        {
			Name = "Dwayne";
        }
		public override RPS GenerateRPS()
        {
			return RPS.rock;
        }
	}


}
