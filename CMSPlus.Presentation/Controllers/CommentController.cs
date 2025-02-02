using AutoMapper;
using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Models.CommentModel;
using CMSPlus.Domain.Models.CommunModels;
using CMSPlus.Domain.Models.TopicModels;
using CMSPlus.Services.Interfaces;
using CMSPlus.Services.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace CMSPlus.Presentation.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;
        private readonly IValidator<CommentCreateModel> _createModelValidator;
        public CommentController(ICommentService commentService, IMapper mapper, IValidator<CommentCreateModel> createModelValidator)
        {
            _commentService = commentService;
            _mapper = mapper;
            _createModelValidator = createModelValidator;
        }
    }
}
