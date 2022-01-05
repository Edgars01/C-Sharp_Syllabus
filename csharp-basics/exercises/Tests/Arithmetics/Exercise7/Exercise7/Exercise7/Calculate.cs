using System;

namespace Exercise7
{
    public class Calculate : ICalculate
    {
        public double gravity = -9.81;
        public double fallingTime = 10.0;
        public double initialVelocity = 0.0;

        public double Gravity()
        {
            return gravity;
        }

        public double InitialVelocity()
        {
            return initialVelocity;
        }

        public double FallingTime()
        {
            return fallingTime;
        }

        public double InitialPosition()
        {
            return 0.0;
        }

        public double FinalPositionAfterTenSec()
        {
            return 0.5 * (gravity * (fallingTime * fallingTime)) + initialVelocity * fallingTime;
        }

        public double FinalPositionAfter51Sec()
        {
            return 0.5 * (gravity * (51 * 51)) + initialVelocity * 51;
        }
    }
}
