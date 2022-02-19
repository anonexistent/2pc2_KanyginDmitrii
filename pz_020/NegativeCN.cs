using System;

namespace pz_020
{
    class NegativeCN : ConplexNumber
    {
        public NegativeCN(float num1, float num2) : base(num1, num2)
        {
            base.A = -A;
        }
        public override void GetComplexNumber()
        {
            Console.WriteLine(
                   $"real: {-A}\n" +
                   $"negative real: {A}\n" +
                   $"imaginary: {B}\n" +
                   $"CN: {base.CNString(A, B)}\n"
                       );
        }
    }
}
