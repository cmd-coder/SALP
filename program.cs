class program
{
	static void Main(string args[])
	{
		Console.WriteLine("Welcome to Snake and Ladder Problem");
		int numOfPlayers = 2;
		int [] startPoint = {0,0};
		Console.WriteLine("Two players will start from origin");
		Random ran=new Random();
		while (startPoint1 != 100 && startPoint2!=100)
		{
			for(int i=0;i<2;i++)
			{
				int roll=ran.Next(1,7);
				int option = ran.Next(1,4);
				if(option==2)
					startPoint[i]+=roll;
				else if(option==3)
					startPoint[i]-=roll;
				if(startPoint[i]<0)
					startPoint[i]=0;
				if(startPoint[i]>100)
					startPoint[i]-=roll;
				if(option==2)
					i--;
			}
		}
		Console.WriteLine("Player 1 is at "+startPoint[0]+" and Player 2 is at "+startPoint[1]);
		if(startPoint[0]==100)
			Console.WriteLine("Player 1 has won");
		else
			Console.WriteLine("Player 2 has won");
	}
}
