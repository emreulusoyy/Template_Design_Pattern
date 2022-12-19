namespace Template_Design_Pattern.TemplateDesignPattern
{
    public class GoldUserCardTemplate : UserCardTemplate
    {
        protected override string SetFooter()
        {
            return string.Empty;
        }

        protected override string SetImage()
        {
            return "<img class='card-img-top' src='/images/user.png' style='width:50px; height:50px;'>";
        }
    }
}
