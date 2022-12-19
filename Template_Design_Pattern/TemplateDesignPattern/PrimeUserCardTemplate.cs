using System.Text;

namespace Template_Design_Pattern.TemplateDesignPattern
{
    public class PrimeUserCardTemplate : UserCardTemplate
    {
        protected override string SetFooter()
        {
            var sb = new StringBuilder();
            sb.Append("<a href='#' class='btn btn-primary'>Profili Gör</a>");
            sb.Append("<a href='#' class='btn btn-success'>Mesaj Gönder</a>");
            return sb.ToString();
        }

        protected override string SetImage()
        {
            return $"<img class='card-img-top' src='{AppUser.Image}' style='width:50px; height:50px;'>";
        }
    }
}
