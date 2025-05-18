using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [Serializable]
    public partial class Entities : DbContext
    {
        private Entities(DbConnection connectionString, bool contextOwnsConnection = true) 
            : base(connectionString, contextOwnsConnection) { }
        public static Entities CreateEntities(bool contextOwnsConnection = true)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open("connectdb.dba", FileMode.Open, FileAccess.Read);
            connect cp = (connect)bf.Deserialize(fs);

            //string servername = Encryptor.Decrypt(cp.servername, "qwertyuiop", true);
            string servername = "LAPTOP-KJ2T5301\\SQLEXPRESS01";
            //  string username = Encryptor.Decrypt(cp.username, "qwertyuiop", true);
            // string pass = Encryptor.Decrypt(cp.passwd, "qwertyuiop", true);
            //string database = Encryptor.Decrypt(cp.database, "qwertyuiop", true);
            string database = "QUANLY_KHOHANG";

            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            SqlConnectionStringBuilder sqlConnectBuiler = new SqlConnectionStringBuilder();
            sqlConnectBuiler.DataSource = servername;
            sqlConnectBuiler.InitialCatalog = database;
            // sqlConnectBuiler.UserID = username;
            // sqlConnectBuiler.Password = pass;
            sqlConnectBuiler.IntegratedSecurity = true;

            string sqlConnectionString = sqlConnectBuiler.ConnectionString;

            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
            entityBuilder.Provider = "System.Data.SqlClient";
            entityBuilder.ProviderConnectionString = sqlConnectionString;

            entityBuilder.Metadata = @"res://*/KHOHANG.csdl|res://*/KHOHANG.ssdl|res://*/KHOHANG.msl";

            EntityConnection connection = new EntityConnection(entityBuilder.ConnectionString);

            fs.Close();
            return new Entities(connection);
        }
        public virtual DbSet<tb_CHUNGTU> tb_CHUNGTU { get; set; }
        public virtual DbSet<tb_CHUNGTU_CT> tb_CHUNGTU_CT { get; set; }
        public virtual DbSet<tb_CONGTY> tb_CONGTY { get; set; }
        public virtual DbSet<tb_DONVI> tb_DONVI { get; set; }
        public virtual DbSet<tb_DVT> tb_DVT { get; set; }
        public virtual DbSet<tb_HANGHOA> tb_HANGHOA { get; set; }
        public virtual DbSet<tb_SYS_FUNC> tb_SYS_FUNC { get; set; }
        public virtual DbSet<tb_SYS_GROUP> tb_SYS_GROUP { get; set; }
        public virtual DbSet<tb_SYS_REPORT> tb_SYS_REPORT { get; set; }
        public virtual DbSet<tb_SYS_RIGHT> tb_SYS_RIGHT { get; set; }
        public virtual DbSet<tb_SYS_RIGHT_REP> tb_SYS_RIGHT_REP { get; set; }
        public virtual DbSet<tb_SYS_USER> tb_SYS_USER { get; set; }
        public virtual DbSet<tb_TONKHO> tb_TONKHO { get; set; }
        public virtual DbSet<tb_XUATXU> tb_XUATXU { get; set; }
        public virtual DbSet<tb_NHACUNGCAP> tb_NHACUNGCAP { get; set; }
        public virtual DbSet<tb_NHOMHH> tb_NHOMHH { get; set; }
        public virtual DbSet<tb_SYS_SEQUENCE> tb_SYS_SEQUENCE { get; set; }
        public virtual DbSet<V_FUNC_SYS_RIGHT> V_FUNC_SYS_RIGHT { get; set; }
        public virtual DbSet<V_REP_SYS_RIGHT_REP> V_REP_SYS_RIGHT_REP { get; set; }
        public virtual DbSet<V_USER_IN_GROUP> V_USER_IN_GROUP { get; set; }
        public virtual DbSet<V_USER_NOTIN_GROUP> V_USER_NOTIN_GROUP { get; set; }
        public virtual DbSet<tb_KHACHHANG> tb_KHACHHANG { get; set; }
        public virtual int TINH_TONKHO_DONVI(Nullable<System.DateTime> nGAYC, string mADVI)
        {
            var nGAYCParameter = nGAYC.HasValue ?
                new ObjectParameter("NGAYC", nGAYC) :
                new ObjectParameter("NGAYC", typeof(System.DateTime));

            var mADVIParameter = mADVI != null ?
                new ObjectParameter("MADVI", mADVI) :
                new ObjectParameter("MADVI", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TINH_TONKHO_DONVI", nGAYCParameter, mADVIParameter);
        }
        public virtual int TINH_TONKHO_CONGTY(Nullable<System.DateTime> nGAYC, string mACTY)
        {
            var nGAYCParameter = nGAYC.HasValue ?
                new ObjectParameter("NGAYC", nGAYC) :
                new ObjectParameter("NGAYC", typeof(System.DateTime));

            var mACTYParameter = mACTY != null ?
                new ObjectParameter("MACTY", mACTY) :
                new ObjectParameter("MACTY", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TINH_TONKHO_CONGTY", nGAYCParameter, mACTYParameter);
        }

    }


}
