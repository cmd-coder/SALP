class program
{
	static void main(String args[])
	{
		Console.WriteLine("Welcome to Snake and Ladder Problem");
		int numOfPlayers = 1;
		int startPoint = 0;
		Console.WriteLine("Single player will start from origin");
		Random ran=new Random();
		int count=0;
		while (startPoint != 100)
		{
			int roll=ran.Next(1,7);
			int option = ran.Next(1,4);
			count++;
			if(option==2)
				startPoint+=roll;
			else if(option==3)
				startPoint-=roll;
			if(startPoint<0)
				startPoint=0;
			if(stratPoint>100)
				startPoint-=roll;
			Console.Write(startPoint+" ");
		}
		Console.WriteLine("100");
		Console.WriteLine("The number of times the die was rolled: "+count);
	}
}
