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
        public bool IsRequired(string fullName)
        {
            return !string.IsNullOrWhiteSpace(fullName);
        }

    }
}
