namespace TeploobLibrary1
{
    public class TeploobmenLib
    {
        public TeploobmenOutputData Calc(TeploobmenInputData data)
        {
            return new TeploobmenOutputData
            {
                Sum = data.X + data.Y + data.Z,
                Minus = data.X - data.Y - data.Z,
                Proizv = data.X * data.Y * data.Z,
            };
                
        }
    }
}
