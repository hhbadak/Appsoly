using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
        }

        #region Yönetici Metotları

        public Team AdminLogin(string username, string password)
        {
            try
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Team WHERE Username = @username AND Password = @password";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                con.Open();
                int number = Convert.ToInt32(cmd.ExecuteScalar());

                if (number > 0)
                {
                    cmd.CommandText = "SELECT ID, Name, UserName, Img, Status FROM Team WHERE UserName = @username AND Password = @password";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = cmd.ExecuteReader();
                    Team t = new Team();
                    while (reader.Read())
                    {
                        t.ID = reader.GetInt32(0);
                        t.Name = reader.GetString(1);
                        t.UserName = reader.GetString(2);
                        t.Img = reader.GetString(3);
                        t.Status = reader.GetBoolean(4);
                    }
                    return t;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }

        public List<Team> TeamList()
        {
            List<Team> team = new List<Team>();
            try
            {
                cmd.CommandText = "Select * From Team";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Team t = new Team();
                    t.ID = reader.GetInt32(0);
                    t.Name = reader.GetString(1);
                    t.UserName = reader.GetString(2);
                    t.Password = reader.GetString(3);
                    t.Img = reader.GetString(4);
                    t.Status = reader.GetBoolean(5);
                    team.Add(t);
                }
                return team;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region BLOG METOT
        public bool CreateBlog(Blog master)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Blog(Title, Brief, ImgThumb, Image1, Contents1, Contents2, Image2, ImportantInformation, Content2Continued, Weld, ServiceID, TeamID, Date) VALUES (@title, @brief, @imgthumb, @img1, @cont1, @cont2, @img2, @imporinfo, @con2continued, @weld, @seid, @tid, @date)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@title", master.Title);
                cmd.Parameters.AddWithValue("@brief", master.Brief);
                cmd.Parameters.AddWithValue("@imgthumb", master.ImgThumb);
                cmd.Parameters.AddWithValue("@img1", master.Image1);
                cmd.Parameters.AddWithValue("@cont1", master.Contents1);
                cmd.Parameters.AddWithValue("@cont2", master.Contents2);
                cmd.Parameters.AddWithValue("@img2", master.Image2);
                cmd.Parameters.AddWithValue("@imporinfo", master.ImportantInformation);
                cmd.Parameters.AddWithValue("@con2continued", master.Content2Continued);
                cmd.Parameters.AddWithValue("@weld", master.Weld);
                cmd.Parameters.AddWithValue("@seid", master.ServiceID);
                cmd.Parameters.AddWithValue("@tid", master.TeamID);
                cmd.Parameters.AddWithValue("@date", master.Date);
                con.Open();
                cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Blog> BlogList()
        {
            List<Blog> blog = new List<Blog>();
            try
            {
                cmd.CommandText = "SELECT b.ID, b.Title, b.Brief, b.ImgThumb, b.Image1, b.Contents1, b.Contents2, b.Image2, b.ImportantInformation, b.Content2Continued, b.Weld, s.Service, b.Date \r\nFROM Blog AS b\r\nJOIN Services AS s ON s.ID = b.ServiceID";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Blog b = new Blog();
                    b.ID = reader.GetInt32(0);
                    b.Title = reader.GetString(1);
                    b.Brief = reader.GetString(2);
                    b.ImgThumb = reader.GetString(3);
                    b.Image1 = reader.GetString(4);
                    b.Contents1 = reader.GetString(5);
                    b.Contents2 = reader.GetString(6);
                    b.Image2 = reader.GetString(7);
                    b.ImportantInformation = reader.GetString(8);
                    b.Content2Continued = reader.GetString(9);
                    b.Weld = reader.GetString(10);
                    b.Service = reader.GetString(11);
                    b.Date = reader.GetDateTime(12);
                    blog.Add(b);
                }
                return blog;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool DeleteBlog(int id)
        {
            try
            {
                cmd.CommandText = "DELETE Blog WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Blog> ListBlog(int bid)
        {
            try
            {
                List<Blog> blogs = new List<Blog>();
                cmd.CommandText = "SELECT TOP 3 b.ID, b.Title, b.Brief, b.ImgThumb, b.Image1, b.Contents1, b.Contents2, b.Image2, b.ImportantInformation, b.Content2Continued, b.Weld, s.Service, t.Username, b.Date " +
                                  "FROM Blog AS b " +
                                  "JOIN Services AS s ON s.ID = b.ServiceID " +
                                  "JOIN Team AS t ON t.ID = b.TeamID " +
                                  "WHERE b.ID = @bid " +
                                  "ORDER BY b.Date DESC;";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@bid", bid);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Blog b = new Blog();
                    b.ID = reader.GetInt32(0);
                    b.Title = reader.GetString(1);
                    b.Brief = reader.GetString(2);
                    b.ImgThumb = reader.GetString(3);
                    b.Image1 = reader.GetString(4);
                    b.Contents1 = reader.GetString(5);
                    b.Contents2 = reader.GetString(6);
                    b.Image2 = reader.GetString(7);
                    b.ImportantInformation = reader.GetString(8);
                    b.Content2Continued = reader.GetString(9);
                    b.Weld = reader.GetString(10);
                    b.Service = reader.GetString(11);
                    b.Team = reader.GetString(12);
                    b.Date = reader.GetDateTime(13);
                    blogs.Add(b);
                }
                return blogs;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Blog> ListBlog()
        {
            try
            {
                List<Blog> blogs = new List<Blog>();
                cmd.CommandText = "SELECT TOP 3 b.ID, b.Title, b.Brief, b.ImgThumb, b.Image1, b.Contents1, b.Contents2, b.Image2, b.ImportantInformation, b.Content2Continued, b.Weld, s.Service, t.Username, b.Date " +
                                  "FROM Blog AS b " +
                                  "JOIN Services AS s ON s.ID = b.ServiceID " +
                                  "JOIN Team AS t ON t.ID = b.TeamID " +
                                  "ORDER BY b.Date DESC;";
                cmd.Parameters.Clear();

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Blog b = new Blog();
                    b.ID = reader.GetInt32(0);
                    b.Title = reader.GetString(1);
                    b.Brief = reader.GetString(2);
                    b.ImgThumb = reader.GetString(3);
                    b.Image1 = reader.GetString(4);
                    b.Contents1 = reader.GetString(5);
                    b.Contents2 = reader.GetString(6);
                    b.Image2 = reader.GetString(7);
                    b.ImportantInformation = reader.GetString(8);
                    b.Content2Continued = reader.GetString(9);
                    b.Weld = reader.GetString(10);
                    b.Service = reader.GetString(11);
                    b.Team = reader.GetString(12);
                    b.Date = reader.GetDateTime(13);
                    blogs.Add(b);
                }
                return blogs;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Blog> ListBlogSoftware()
        {
            try
            {
                List<Blog> blogs = new List<Blog>();
                cmd.CommandText = "SELECT b.ID, b.Title, b.Brief, b.ImgThumb, b.Image1, b.Contents1, b.Contents2, b.Image2, b.ImportantInformation, b.Content2Continued, b.Weld, s.Service, t.Username, b.Date " +
                                  "FROM Blog AS b " +
                                  "JOIN Services AS s ON s.ID = b.ServiceID " +
                                  "JOIN Team AS t ON t.ID = b.TeamID " +
                                  "WHERE b.ServiceID = 1" +
                                  "ORDER BY b.Date DESC;";
                cmd.Parameters.Clear();

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Blog b = new Blog();
                    b.ID = reader.GetInt32(0);
                    b.Title = reader.GetString(1);
                    b.Brief = reader.GetString(2);
                    b.ImgThumb = reader.GetString(3);
                    b.Image1 = reader.GetString(4);
                    b.Contents1 = reader.GetString(5);
                    b.Contents2 = reader.GetString(6);
                    b.Image2 = reader.GetString(7);
                    b.ImportantInformation = reader.GetString(8);
                    b.Content2Continued = reader.GetString(9);
                    b.Weld = reader.GetString(10);
                    b.Service = reader.GetString(11);
                    b.Team = reader.GetString(12);
                    b.Date = reader.GetDateTime(13);
                    blogs.Add(b);
                }
                return blogs;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Blog> ListBlogSocial()
        {
            try
            {
                List<Blog> blogs = new List<Blog>();
                cmd.CommandText = "SELECT b.ID, b.Title, b.Brief, b.ImgThumb, b.Image1, b.Contents1, b.Contents2, b.Image2, b.ImportantInformation, b.Content2Continued, b.Weld, s.Service, t.Username, b.Date " +
                                  "FROM Blog AS b " +
                                  "JOIN Services AS s ON s.ID = b.ServiceID " +
                                  "JOIN Team AS t ON t.ID = b.TeamID " +
                                  "WHERE b.ServiceID = 2" +
                                  "ORDER BY b.Date DESC;";
                cmd.Parameters.Clear();

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Blog b = new Blog();
                    b.ID = reader.GetInt32(0);
                    b.Title = reader.GetString(1);
                    b.Brief = reader.GetString(2);
                    b.ImgThumb = reader.GetString(3);
                    b.Image1 = reader.GetString(4);
                    b.Contents1 = reader.GetString(5);
                    b.Contents2 = reader.GetString(6);
                    b.Image2 = reader.GetString(7);
                    b.ImportantInformation = reader.GetString(8);
                    b.Content2Continued = reader.GetString(9);
                    b.Weld = reader.GetString(10);
                    b.Service = reader.GetString(11);
                    b.Team = reader.GetString(12);
                    b.Date = reader.GetDateTime(13);
                    blogs.Add(b);
                }
                return blogs;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Blog> ListBlogSeo()
        {
            try
            {
                List<Blog> blogs = new List<Blog>();
                cmd.CommandText = "SELECT b.ID, b.Title, b.Brief, b.ImgThumb, b.Image1, b.Contents1, b.Contents2, b.Image2, b.ImportantInformation, b.Content2Continued, b.Weld, s.Service, t.Username, b.Date " +
                                  "FROM Blog AS b " +
                                  "JOIN Services AS s ON s.ID = b.ServiceID " +
                                  "JOIN Team AS t ON t.ID = b.TeamID " +
                                  "WHERE b.ServiceID = 3" +
                                  "ORDER BY b.Date DESC;";
                cmd.Parameters.Clear();

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Blog b = new Blog();
                    b.ID = reader.GetInt32(0);
                    b.Title = reader.GetString(1);
                    b.Brief = reader.GetString(2);
                    b.ImgThumb = reader.GetString(3);
                    b.Image1 = reader.GetString(4);
                    b.Contents1 = reader.GetString(5);
                    b.Contents2 = reader.GetString(6);
                    b.Image2 = reader.GetString(7);
                    b.ImportantInformation = reader.GetString(8);
                    b.Content2Continued = reader.GetString(9);
                    b.Weld = reader.GetString(10);
                    b.Service = reader.GetString(11);
                    b.Team = reader.GetString(12);
                    b.Date = reader.GetDateTime(13);
                    blogs.Add(b);
                }
                return blogs;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Blog> ListBlogMobile()
        {
            try
            {
                List<Blog> blogs = new List<Blog>();
                cmd.CommandText = "SELECT b.ID, b.Title, b.Brief, b.ImgThumb, b.Image1, b.Contents1, b.Contents2, b.Image2, b.ImportantInformation, b.Content2Continued, b.Weld, s.Service, t.Username, b.Date " +
                                  "FROM Blog AS b " +
                                  "JOIN Services AS s ON s.ID = b.ServiceID " +
                                  "JOIN Team AS t ON t.ID = b.TeamID " +
                                  "WHERE b.ServiceID = 5" +
                                  "ORDER BY b.Date DESC;";
                cmd.Parameters.Clear();

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Blog b = new Blog();
                    b.ID = reader.GetInt32(0);
                    b.Title = reader.GetString(1);
                    b.Brief = reader.GetString(2);
                    b.ImgThumb = reader.GetString(3);
                    b.Image1 = reader.GetString(4);
                    b.Contents1 = reader.GetString(5);
                    b.Contents2 = reader.GetString(6);
                    b.Image2 = reader.GetString(7);
                    b.ImportantInformation = reader.GetString(8);
                    b.Content2Continued = reader.GetString(9);
                    b.Weld = reader.GetString(10);
                    b.Service = reader.GetString(11);
                    b.Team = reader.GetString(12);
                    b.Date = reader.GetDateTime(13);
                    blogs.Add(b);
                }
                return blogs;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Blog> ListBlogBt()
        {
            try
            {
                List<Blog> blogs = new List<Blog>();
                cmd.CommandText = "SELECT b.ID, b.Title, b.Brief, b.ImgThumb, b.Image1, b.Contents1, b.Contents2, b.Image2, b.ImportantInformation, b.Content2Continued, b.Weld, s.Service, t.Username, b.Date " +
                                  "FROM Blog AS b " +
                                  "JOIN Services AS s ON s.ID = b.ServiceID " +
                                  "JOIN Team AS t ON t.ID = b.TeamID " +
                                  "WHERE b.ServiceID = 4" +
                                  "ORDER BY b.Date DESC;";
                cmd.Parameters.Clear();

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Blog b = new Blog();
                    b.ID = reader.GetInt32(0);
                    b.Title = reader.GetString(1);
                    b.Brief = reader.GetString(2);
                    b.ImgThumb = reader.GetString(3);
                    b.Image1 = reader.GetString(4);
                    b.Contents1 = reader.GetString(5);
                    b.Contents2 = reader.GetString(6);
                    b.Image2 = reader.GetString(7);
                    b.ImportantInformation = reader.GetString(8);
                    b.Content2Continued = reader.GetString(9);
                    b.Weld = reader.GetString(10);
                    b.Service = reader.GetString(11);
                    b.Team = reader.GetString(12);
                    b.Date = reader.GetDateTime(13);
                    blogs.Add(b);
                }
                return blogs;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Blog> ListBlogDetail(int bid)
        {
            try
            {
                List<Blog> blogs = new List<Blog>();
                cmd.CommandText = "SELECT b.ID, b.Title, b.Brief, b.ImgThumb, b.Image1, b.Contents1, b.Contents2, b.Image2, b.ImportantInformation, b.Content2Continued, b.Weld, s.Service, t.Username, b.Date, " +
                                  "(SELECT COUNT(*) FROM BlogComment WHERE BlogComment.BlogID = b.ID) AS CommentCount " +
                                  "FROM Blog AS b " +
                                  "JOIN Services AS s ON s.ID = b.ServiceID " +
                                  "JOIN Team AS t ON t.ID = b.TeamID " +
                                  "WHERE b.ID = @bid " +
                                  "ORDER BY b.Date DESC;";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@bid", bid);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Blog b = new Blog();
                    b.ID = reader.GetInt32(0);
                    b.Title = reader.GetString(1);
                    b.Brief = reader.GetString(2);
                    b.ImgThumb = reader.GetString(3);
                    b.Image1 = reader.GetString(4);
                    b.Contents1 = reader.GetString(5);
                    b.Contents2 = reader.GetString(6);
                    b.Image2 = reader.GetString(7);
                    b.ImportantInformation = reader.GetString(8);
                    b.Content2Continued = reader.GetString(9);
                    b.Weld = reader.GetString(10);
                    b.Service = reader.GetString(11);
                    b.Team = reader.GetString(12);
                    b.Date = reader.GetDateTime(13);
                    b.CommentCount = reader.GetInt32(14); // Yorum sayısını ekliyoruz
                    blogs.Add(b);
                }
                return blogs;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }


        #endregion

        #region SERVICE METOT
        public List<Services> ServiceList()
        {
            List<Services> srv = new List<Services>();
            try
            {
                cmd.CommandText = "SELECT * FROM Services";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Services s = new Services();
                    s.ID = reader.GetInt32(0);
                    s.Service = reader.GetString(1);
                    srv.Add(s);
                }
                reader.Close();
                return srv;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region COMMENT METOT

        public List<BlogComment> ListComment(int bid)
        {
            try
            {
                List<BlogComment> comments = new List<BlogComment>();
                cmd.CommandText = "SELECT ID, BlogID, Name, EMail, Comment, Date FROM BlogComment WHERE BlogID = @bid";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@bid", bid);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BlogComment bc = new BlogComment();
                    bc.ID = reader.GetInt32(0);
                    bc.BlogID = reader.GetInt32(1);
                    bc.Name = reader.GetString(2);
                    bc.EMail = reader.GetString(3);
                    bc.Comment = reader.GetString(4);
                    bc.Date = reader.GetDateTime(5);
                    comments.Add(bc);
                }
                return comments;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool DataControl(string comment)
        {
            try
            {
                cmd.CommandText = "SELECT COUNT(*) FROM BlogComment WHERE Comment = @comment";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@comment", comment);
                con.Open();
                int sayi = Convert.ToInt32(cmd.ExecuteScalar());
                if (sayi == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally { con.Close(); }
        }

        public bool CreateComment(BlogComment meta)
        {
            try
            {
                cmd.CommandText = "INSERT INTO BlogComment(BlogID, Name, EMail, Comment, Date) VALUES(@bid, @name, @email, @comment, @date)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@bid", meta.BlogID);
                cmd.Parameters.AddWithValue("@name", meta.Name);
                cmd.Parameters.AddWithValue("@email", meta.EMail);
                cmd.Parameters.AddWithValue("@comment", meta.Comment);
                cmd.Parameters.AddWithValue("@date", meta.Date);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            { return false; }
            finally { con.Close(); }
        }
        #endregion

        #region CUSTOMER METOT

        public List<Customers> ListCustomer()
        {
            List<Customers> customer = new List<Customers>();
            try
            {
                cmd.CommandText = "SELECT * FROM Customers";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Customers c = new Customers();
                    c.ID = reader.GetInt32(0);
                    c.Name = reader.GetString(1);
                    c.Company = reader.GetString(2);
                    c.CompanyPosition = reader.GetString(3);
                    c.Mail = reader.GetString(4);
                    c.Phone = reader.GetString(5);
                    c.Image = reader.GetString(6);
                    c.City = reader.GetString(7);
                    c.CreateDate = reader.GetDateTime(8);
                    c.Status = reader.GetBoolean(9);
                    c.StatusStr = reader.GetBoolean(9) ? "<label style='color:green'>Aktif</label>" : "<label style='color:gray'>Pasif</label>";
                    customer.Add(c);
                }
                return customer;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool DeleteCustomer(int id)
        {
            try
            {
                cmd.CommandText = "DELETE Customers WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region SUBSCRIBE METOT

        public bool SubscribeDataControl(string mail)
        {
            try
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Subscription WHERE EMail = @mail";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mail", mail);
                con.Open();
                int sayi = Convert.ToInt32(cmd.ExecuteScalar());
                if (sayi == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally { con.Close(); }
        }

        public bool CreateSubscribe(Subscription meta)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Subscription(EMail) VALUES(@email)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@email", meta.EMail);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            { return false; }
            finally { con.Close(); }
        }
        #endregion

        #region CUSTOMER METOT

        public bool CreateCustomer(Customers master)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Customers(Name, Company, CompanyPosition, Mail, Phone, Image, City, CreateDate, Status) VALUES (@name, @company, @cposi, @mail, @phone, @img, @city, @date, @status)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", master.Name);
                cmd.Parameters.AddWithValue("@company", master.Company);
                cmd.Parameters.AddWithValue("@cposi", master.CompanyPosition);
                cmd.Parameters.AddWithValue("@mail", master.Mail);
                cmd.Parameters.AddWithValue("@phone", master.Phone);
                cmd.Parameters.AddWithValue("@img", master.Image);
                cmd.Parameters.AddWithValue("@city", master.City);
                cmd.Parameters.AddWithValue("@date", master.CreateDate);
                cmd.Parameters.AddWithValue("@status", master.Status);
                con.Open();
                cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region PAYE METOT
        public bool CreatePayee(Payees master)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Payees(Name) VALUES (@name)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", master.Name);
                con.Open();
                cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Payees> PayeeList()
        {
            try
            {
                List<Payees> payees = new List<Payees>();
                cmd.CommandText = "SELECT ID, Name FROM Payees";
                cmd.Parameters.Clear();

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Payees p = new Payees();
                    p.ID = reader.GetInt32(0);
                    p.Name = reader.GetString(1);
                    payees.Add(p);
                }
                return payees;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool DeletePayee(int id)
        {
            try
            {
                cmd.CommandText = "DELETE Payees WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }


        #endregion

        #region DEBTS METOT
        public bool CreateDebt(Debts master)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Debts(PayeeID, TotalDebt, MonthlyPayment, Statu) VALUES (@payid, @totd, @month, @statu)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@payid", master.PayeeID);
                cmd.Parameters.AddWithValue("@totd", master.TotalDebt);
                cmd.Parameters.AddWithValue("@month", master.MonthlyPayment);
                cmd.Parameters.AddWithValue("@statu", master.Statu);
                con.Open();
                cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Debts> DebtListFromPayee()
        {
            try
            {
                List<Debts> debt = new List<Debts>();
                cmd.CommandText = "SELECT d.ID, p.Name, d.TotalDebt, d.MonthlyPayment, d.Statu FROM Debts AS d\r\nJOIN Payees AS p ON p.ID = d.PayeeID";
                cmd.Parameters.Clear();

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Debts d = new Debts();
                    d.ID = reader.GetInt32(0);
                    d.Payee = reader.GetString(1);
                    d.TotalDebt = reader.GetDecimal(2);
                    d.MonthlyPayment = reader.GetDecimal(3);
                    d.Statu = reader.GetBoolean(4);
                    debt.Add(d);
                }
                return debt;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool DeleteDebt(int id)
        {
            try
            {
                cmd.CommandText = "DELETE Debts WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region DEBT DETAIL METOT
        public bool CreateDebtDetail(DebtDetails master)
        {
            try
            {
                cmd.CommandText = "INSERT INTO DebtDetails(DebtID, MonthlyPayment, InstallmentDate, Status) VALUES (@debid, @month, @insdate, @statu)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@debid", master.DebtID);
                cmd.Parameters.AddWithValue("@month", master.MonthlyPayment);
                cmd.Parameters.AddWithValue("@insdate", master.InstallmentDate);
                cmd.Parameters.AddWithValue("@statu", master.Status);
                con.Open();
                cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public List<DebtDetails> DebtDeatilListFromPayee()
        {
            try
            {
                List<DebtDetails> debtdet = new List<DebtDetails>();
                cmd.CommandText = "SELECT dd.ID, p.Name, dd.MonthlyPayment, dd.InstallmentDate, dd.Status FROM DebtDetails AS dd\r\nJOIN Debts AS d ON d.ID = dd.DebtID\r\nJOIN Payees AS p ON p.ID = d.PayeeID";
                cmd.Parameters.Clear();

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DebtDetails dd = new DebtDetails();
                    dd.ID = reader.GetInt32(0);
                    dd.Payee = reader.GetString(1);
                    dd.MonthlyPayment = reader.GetDecimal(2);
                    dd.InstallmentDate = reader.GetDateTime(3);
                    dd.Status = reader.GetBoolean(4);
                    dd.StatusStr = reader.GetBoolean(4) ?
     "<i class='fa fa-ban' style='color:red'></i>" :
    "<i class='fa fa-check-circle' style='color:green'></i>";
                    debtdet.Add(dd);
                }
                return debtdet;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<DebtDetails> DebtDeatilListFromID(int id)
        {
            try
            {
                List<DebtDetails> debtdet = new List<DebtDetails>();
                cmd.CommandText = "SELECT dd.ID, p.Name, dd.MonthlyPayment, dd.InstallmentDate, dd.Status FROM DebtDetails AS dd " +
                                  "JOIN Debts AS d ON d.ID = dd.DebtID " +
                                  "JOIN Payees AS p ON p.ID = d.PayeeID WHERE d.ID = @id";
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DebtDetails dd = new DebtDetails();
                    dd.ID = reader.GetInt32(0);
                    dd.Payee = reader.GetString(1);
                    dd.MonthlyPayment = reader.GetDecimal(2);
                    dd.InstallmentDate = reader.GetDateTime(3);
                    dd.Status = reader.GetBoolean(4);
                    dd.StatusStr = reader.GetBoolean(4) ?
                        "<i class='fa fa-ban' style='color:red'></i>" :
                        "<i class='fa fa-check-circle' style='color:green'></i>";
                    debtdet.Add(dd);
                }
                return debtdet;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<DebtDetails> DebtDeatilListFromDate()
        {
            try
            {
                List<DebtDetails> debtdet = new List<DebtDetails>();
                cmd.CommandText = @"
            SELECT dd.ID, p.Name, dd.MonthlyPayment, dd.InstallmentDate, dd.Status 
            FROM DebtDetails AS dd
            JOIN Debts AS d ON d.ID = dd.DebtID
            JOIN Payees AS p ON p.ID = d.PayeeID
            WHERE MONTH(dd.InstallmentDate) = MONTH(GETDATE()) 
            AND YEAR(dd.InstallmentDate) = YEAR(GETDATE())"; // Filter by current month and year
                cmd.Parameters.Clear();

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DebtDetails dd = new DebtDetails();
                    dd.ID = reader.GetInt32(0);
                    dd.Payee = reader.GetString(1);
                    dd.MonthlyPayment = reader.GetDecimal(2);
                    dd.InstallmentDate = reader.GetDateTime(3);
                    dd.Status = reader.GetBoolean(4);
                    dd.StatusStr = dd.Status ?
                        "<i class='fa fa-ban' style='color:red'></i>" :
                        "<i class='fa fa-check-circle' style='color:green'></i>";
                    debtdet.Add(dd);
                }
                return debtdet;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<DebtDetails> DebtDeatilListFromPayFalse()
        {
            try
            {
                List<DebtDetails> debtdet = new List<DebtDetails>();
                cmd.CommandText = "SELECT dd.ID, p.Name, dd.MonthlyPayment, dd.InstallmentDate, dd.Status FROM DebtDetails AS dd\r\nJOIN Debts AS d ON d.ID = dd.DebtID\r\nJOIN Payees AS p ON p.ID = d.PayeeID WHERE dd.Status = 1";
                cmd.Parameters.Clear();

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DebtDetails dd = new DebtDetails();
                    dd.ID = reader.GetInt32(0);
                    dd.Payee = reader.GetString(1);
                    dd.MonthlyPayment = reader.GetDecimal(2);
                    dd.InstallmentDate = reader.GetDateTime(3);
                    dd.Status = reader.GetBoolean(4);
                    dd.StatusStr = reader.GetBoolean(4) ?
     "<i class='fa fa-ban' style='color:red'></i>" :
    "<i class='fa fa-check-circle' style='color:green'></i>";
                    debtdet.Add(dd);
                }
                return debtdet;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool DeleteDebtDetail(int id)
        {
            try
            {
                cmd.CommandText = "DELETE DebtDetails WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool UpdateDebtDetail(int id)
        {
            try
            {
                cmd.CommandText = "UPDATE DebtDetails SET Status = 0 WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally { con.Close(); }
        }
        #endregion

        #region INCOME METOT
        public List<Incomes> IncomeListFromPayee()
        {
            try
            {
                List<Incomes> income = new List<Incomes>();
                cmd.CommandText = "SELECT i.ID, iss.Name, i.IncomingFee, i.DATE, i.Description FROM Incomes AS i\r\nJOIN IncomeSource AS iss ON iss.ID = i.IncomeSourceID";
                cmd.Parameters.Clear();

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Incomes i = new Incomes();
                    i.ID = reader.GetInt32(0);
                    i.IncomeSource = reader.GetString(1);
                    i.IncomingFee = reader.GetDecimal(2);
                    i.Date = reader.GetDateTime(3);
                    i.Description = reader.GetString(4);
                    income.Add(i);
                }
                return income;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool CreateIncomeSource(IncomeSource master)
        {
            try
            {
                cmd.CommandText = "INSERT INTO IncomeSource(Name) VALUES (@name)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", master.Name);
                con.Open();
                cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool CreateIncome(Incomes master)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Incomes(IncomeSourceID, IncomingFee, DATE, Description) VALUES (@isid, @if, @date, @desc)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@isid", master.IncomeSourceID);
                cmd.Parameters.AddWithValue("@if", master.IncomingFee);
                cmd.Parameters.AddWithValue("@date", master.Date);
                cmd.Parameters.AddWithValue("@desc", master.Description);
                con.Open();
                cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public List<IncomeSource> IncomeSourceList()
        {
            try
            {
                List<IncomeSource> incomeSource = new List<IncomeSource>();
                cmd.CommandText = "SELECT ID, Name FROM IncomeSource";
                cmd.Parameters.Clear();

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    IncomeSource i = new IncomeSource();
                    i.ID = reader.GetInt32(0);
                    i.Name = reader.GetString(1);
                    incomeSource.Add(i);
                }
                return incomeSource;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region EXPENSES METOT
        public List<Expenses> ExpenseListFromPayee()
        {
            try
            {
                List<Expenses> income = new List<Expenses>();
                cmd.CommandText = "SELECT e.ID, es.Name, e.IncomingFee, e.DATE, e.Description FROM Expenses AS e\r\nJOIN ExpenseSource AS es ON es.ID = e.ExpenseSourceID";
                cmd.Parameters.Clear();

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Expenses i = new Expenses();
                    i.ID = reader.GetInt32(0);
                    i.ExpenseSource = reader.GetString(1);
                    i.OutGoingFee = reader.GetDecimal(2);
                    i.Date = reader.GetDateTime(3);
                    i.Description = reader.GetString(4);
                    income.Add(i);
                }
                return income;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }

        }

        public bool CreateExpenseSource(ExpenseSource master)
        {
            try
            {
                cmd.CommandText = "INSERT INTO ExpenseSource(Name) VALUES (@name)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", master.Name);
                con.Open();
                cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public List<ExpenseSource> ExpenseSourceList()
        {
            try
            {
                List<ExpenseSource> expenseSource = new List<ExpenseSource>();
                cmd.CommandText = "SELECT ID, Name FROM ExpenseSource";
                cmd.Parameters.Clear();

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ExpenseSource e = new ExpenseSource();
                    e.ID = reader.GetInt32(0);
                    e.Name = reader.GetString(1);
                    expenseSource.Add(e);
                }
                return expenseSource;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool CreateExpense(Expenses master)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Expenses(ExpenseSourceID, IncomingFee, DATE, Description) VALUES (@esid, @if, @date, @desc)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@esid", master.ExpenseSourceID);
                cmd.Parameters.AddWithValue("@if", master.OutGoingFee);
                cmd.Parameters.AddWithValue("@date", master.Date);
                cmd.Parameters.AddWithValue("@desc", master.Description);
                con.Open();
                cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
    }
}
