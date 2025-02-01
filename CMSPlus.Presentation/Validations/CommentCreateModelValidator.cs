using CMSPlus.Domain.Models.CommentModel;
using CMSPlus.Domain.Models.TopicModels;
using FluentValidation;

namespace CMSPlus.Presentation.Validations
{
    public class CommentCreateModelValidator : AbstractValidator<CommentCreateModel>
    {
        private readonly CommentValidatorHelpers _commentValidatorHelpers;
        public CommentCreateModelValidator(CommentValidatorHelpers commentValidatorHelpers)
        {
            _commentValidatorHelpers = commentValidatorHelpers;
            RuleFor(comment => comment.FullName)
                .Must(_commentValidatorHelpers.IsUrl).WithMessage("The full name is not an URL");
        }
    }
}
