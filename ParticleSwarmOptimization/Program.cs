using System;

namespace ParticleSwarmOptimization
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var lowerBound = new double[] { 0.0, 0.0 };
            var upperBound = new double[] { 1.0, 1.0 };
            var swarm = new ParticleSwarm(30, lowerBound, upperBound, p =>
            {
                return Math.Cos(p[0]) + Math.Sin(p[1]);
            });

            swarm.Step(50, i => {
                Console.WriteLine($"{i}; {swarm.BestFitness}; {swarm.BestPosition[0]}; {swarm.BestPosition[1]}");
                return Console.KeyAvailable;
            });
            Console.ReadKey();
        }
    }
}
