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
                .Must(_commentValidatorHelpers.IsRequired).WithMessage("The full name is required");

            _commentValidatorHelpers = commentValidatorHelpers;
            RuleFor(comment => comment.Comment)
                .Must(_commentValidatorHelpers.IsRequired).WithMessage("The comment is required");
        }
    }
}
