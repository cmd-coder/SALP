class program
{
	static void Main(string args[])
	{
		Console.WriteLine("Welcome to Snake and Ladder Problem");
		int numOfPlayers = 1;
		int startPoint = 0;
		Console.WriteLine("Single player will start from origin");
		Random ran=new Random();
		int roll=ran.Next(1,7);
		int option = ran.Next(1,4);
		if(option==2)
			startPoint+=roll;
		else if(option==3)
			startPoint-=roll;
		if(startPoint<0)
			startPoint=0;
	}
}
