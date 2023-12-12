namespace TeploobLibrary1
{
    public class TeploobmenLib
    {
        public TeploobmenOutputData Calc(TeploobmenInputData data)
        {
            var rows = new List<TeploobmenOutputRow>();


            for (double i = 0; i <= data.H; i += 0.5)
            {
                rows.Add(new TeploobmenOutputRow { X = i, Y = data.H + i });
            }


            return new TeploobmenOutputData
            {
                Sum = data.H + data.Tmaterial,
                Minus = data.H - data.Tmaterial,
                Proizv = data.H * data.Tmaterial,
                Rows = rows
 
            };
                
        }
    }
}
