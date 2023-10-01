using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Candice B
//CST-250 Milestone Project

namespace CST_250_Milestone_Project
{
	public class Cell
	{
        internal bool visited;

        public int row { get; set; } 
		public int column { get; set; }
		public bool isBomb { get; set; }

		public bool isVisited { get; set; }

		//public int bombsNear { get; set; }
		//constructor
		public Cell(int x, int y)
		{
			row = x;
			column = y;
		}
    }
}
