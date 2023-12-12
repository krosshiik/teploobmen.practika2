namespace TeploobLibrary1
{
    public class TeploobmenLib
    {
        public TeploobmenOutputData Calc(TeploobmenInputData data)
        {
            var rows = new List<TeploobmenOutputRow>();


            for (double i = 0; i < data.Z; i += 0.5)
            {
                rows.Add(new TeploobmenOutputRow { X = i, Y = data.X + i });
            }


            return new TeploobmenOutputData
            {
                Sum = data.X + data.Y,
                Minus = data.X - data.Y,
                Proizv = data.X * data.Y,
                Rows = rows
 
            };
                
        }
    }
}
