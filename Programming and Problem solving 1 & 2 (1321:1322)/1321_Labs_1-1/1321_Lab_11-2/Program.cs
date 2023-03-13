using System;

namespace _Lab_112
{
    class Radio
	{
		private int station, volume;
		private Boolean on;

		public Radio()
		{
			station = 1;
			volume = 1;
			on = true;
		}

		public int getStation()
		{
			return station;
		}

		public int getVolume()
		{
			return volume;
		}

		public void turnOn()
		{
			Console.WriteLine("Turn Radio on:");
			on = true;
			toString();
		}

		public void turnOff()
		{
			Console.WriteLine("Turn Radio off:");
			on = false;
			toString();
		}

		public void stationUp(int i )
		{
			Console.WriteLine("Move station up by " + i + ":");
            for(int j = 0;i != j; j++)
			{
				if (on)
				{
					station++;
				}
			}
			toString();
		}

		public void stationDown(int i)
		{
			Console.WriteLine("Move station down by " + i + ":");
			for (int j = 0; i != j; j++)
			{
				if (on)
				{
					station--;
				}
			}
			toString();
		}

		public void volumeUp(int i)
		{
			Console.WriteLine("Turn volume up by " + i + ":");
			for (int j = 0; j != i;j++)
			{
				if (on)
				{
					volume++;
				}
			}
			toString();
		}

		public void volumeDown(int i)
		{
			Console.WriteLine("Turn volume down by " + i + ":");
            for(int j = 0;j != i;j++)
			{
				if (on)
				{
					volume--;
				}
			}
			toString();
		}

		public void toString()
		{
            if (on)
			{
				Console.WriteLine("     The radio station is " + getStation() + " and the volume level is " + getVolume() + ".\n");
			}
			else
			{
				Console.WriteLine("     The radio is off.\n");
			}
		}
	}

    class MainClass
    {
        public static void Main(string[] args)
        {
			Radio R1 = new Radio();
			R1.turnOn();
			R1.volumeUp(3);
			R1.stationUp(5);
			R1.volumeDown(1);
			R1.stationUp(3);
			R1.turnOff();
			R1.volumeUp(2);
			R1.stationDown(2);

		}
    }
}
