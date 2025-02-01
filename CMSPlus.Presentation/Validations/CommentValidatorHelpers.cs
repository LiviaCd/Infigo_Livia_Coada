using CMSPlus.Services.Interfaces;

namespace CMSPlus.Presentation.Validations
{
    public class CommentValidatorHelpers
    {
        private readonly ICommentService _commentService;
        public CommentValidatorHelpers(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public bool IsUrl(string fullName)
        {
            return Uri.IsWellFormedUriString(fullName, UriKind.RelativeOrAbsolute);
        }
    }
}
