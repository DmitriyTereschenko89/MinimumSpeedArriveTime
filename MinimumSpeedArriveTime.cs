using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSpeedArriveTime
{
	internal class MinimumSpeedArriveTime
	{
		private double ArrivedTime(int[] dist, double speed)
		{
			double hours = 0;
			for (int i = 0; i < dist.Length; ++i)
			{
				double time = dist[i] / speed;
				hours += (i == dist.Length - 1) ? time : Math.Ceiling(time);
			}
			return hours;
		}

		public int MinSpeedOnTime(int[] dist, double hour)
		{
			int minSpeed = 1;
			int minSpeedOnTime = -1;
			int maxSpeed = 1000000000;
			while (minSpeed <= maxSpeed)
			{
				int middleSpeed = (minSpeed + maxSpeed) / 2;
				if (ArrivedTime(dist, middleSpeed) <= hour)
				{
					maxSpeed = middleSpeed - 1;
					minSpeedOnTime = middleSpeed;
				}
				else
				{
					minSpeed = middleSpeed + 1;
				}
			}
			return minSpeedOnTime;
		}
	}
}
