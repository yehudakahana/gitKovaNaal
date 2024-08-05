namespace gitKovaNaal.DAL
{
    public class Data
    {
        private readonly string ConnectionString = "SERVER = DESKTOP-FR8PH7L\\MATAN_SQL;initial catalog=MyShop; user id=SA; " +
            "password=1234;TrustServerCertificate=Yes";
        private static Data _data;
        private DataLayer DataLayer;
        private Data()
        {
            DataLayer = new DataLayer(ConnectionString);
        }
        public static DataLayer Get
        {
            get
            {
                if (_data == null)
                {
                    _data = new Data();
                }
                return _data.DataLayer;
            }
        }
        public void Add()
        {


        }
    }
}
