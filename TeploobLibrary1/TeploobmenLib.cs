namespace TeploobLibrary1
{
    public class TeploobmenLib
    {
        public TeploobmenOutputData Calc(TeploobmenInputData data)
        {
            var rows = new List<TeploobmenOutputRow>();
            var rows1 = new List<TeploobmenOutputRow>();


            double m = Math.Round((data.Gmaterial * data.Rashod) / (data.Cgaza * data.Vgaza * 3.14 * (Math.Pow(data.Dapparata / 2, 2))), 4);

            double y0 = Math.Round((data.AV * data.H) / (data.Vgaza * data.Cgaza * 1000), 4);

            double Y0 = Math.Round(1 - (m * Math.Exp(((m - 1) * y0) / m)), 4);

        
            for (double i = 0; i <= data.H; i += 0.5)
            {
                double Y = Math.Round(((data.AV * i) / (data.Vgaza * data.Cgaza * 1000)), 4);
                double exp1 = Math.Round(1 - Math.Exp(((m - 1) * Y) / m), 4);
                double mexp = Math.Round(1 - m * Math.Exp(((m - 1) * Y) / m), 4);
                double B = Math.Round(exp1/(1 - m * Math.Exp(((m - 1) * y0) / m)), 4);
                double O = Math.Round(mexp / (1 - m * Math.Exp(((m - 1) * y0) / m)), 4);
                double t = Math.Round(data.Tmaterial + (data.Tgaza - data.Tmaterial) * B, 0);
                double T = Math.Round(data.Tmaterial + (data.Tgaza - data.Tmaterial) * O, 0);
                double Tnt = T - t;

                rows.Add(new TeploobmenOutputRow { 
                    X = i,                  
                    t = t,
                    T = T,
                    Tnt = Tnt

                });
            }


            return new TeploobmenOutputData

            {
                Rows = rows,
                Rows1 = rows1,
                Proizv = Y0
            };
                
        }
    }
}
