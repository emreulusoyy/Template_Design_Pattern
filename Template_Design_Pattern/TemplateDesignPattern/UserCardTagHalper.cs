using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Template_Design_Pattern.DAL.Entities;

namespace Template_Design_Pattern.TemplateDesignPattern
{
    public class UserCardTagHalper:TagHelper
    {
        public AppUser AppUser { get; set; }

        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserCardTagHalper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            UserCardTemplate userCardTemplate;

            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                userCardTemplate = new PrimeUserCardTemplate();
            }
            else
            {
                userCardTemplate = new GoldUserCardTemplate();
            }

        }
    }
}
