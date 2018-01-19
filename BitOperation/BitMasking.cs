namespace BitOperation
{
    public class BitMasking
    {
        public int Value { get; set; }
        public int Length { get; set; }

        public BitMasking(int value, int length)
        {
            Value = value;
            Length = length;
        }

        // index i is from 0
        //set(i, mask) – set the i-th bit
        public void Set(int i)
        {
            Value = Value | (1 << i);
        }

        //Unset(i, mask) – unset the i-th bit
        public void Unset(int i)
        {
            Value = Value & ~(1 << i);
        }

        //Check(i, mask) – Check the i-th bit of mask
        public int Check(int i)
        {
            return 1 & Value >> i;
        }

        //count(mask) – the number of non-zero bits in mask
        public int Count()
        {
            int count = 0;
            for (int i = 0; i < Length; i++)
            {
                count += Check(i);
            }
            return count;
        }
    }
}
