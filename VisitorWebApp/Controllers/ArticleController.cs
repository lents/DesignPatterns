using Microsoft.AspNetCore.Mvc;
using VisitorWebApp.Infrastructure.Core;
using VisitorWebApp.Infrastructure.Core.Abstraction;

namespace VisitorWebApp.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;
        private readonly IArticleRepository _articleRepository;
        private readonly IArticleVisitor _articleVisitor;

        public ArticleController(IArticleService articleService, IArticleRepository articleRepository, IArticleVisitor articleVisitor)
        {
            _articleService = articleService;
            _articleRepository = articleRepository;
            _articleVisitor = articleVisitor;
        }

        /// <summary>
        /// Получить данные всех статей
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllArticles()
        {
            var articles = _articleRepository.GetAll();


            return Ok(articles);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var article = _articleRepository.GetArticleById(id);
            if (article == null)
            {
                return NotFound();
            }
            return Ok(article);
        }

        [HttpPost]
        public IActionResult Post([FromBody] IArticle article)
        {
            if (article == null)
            {
                return BadRequest();
            }
            _articleRepository.AddArticle(article);
            return CreatedAtAction("Get", new { id = article.Id }, article);
        }

        [HttpPatch("{id}")]
        public IActionResult Put(int id, [FromBody] IArticle article)
        {
            if (id != article.Id)
            {
                return BadRequest();
            }
            _articleRepository.UpdateArticle(article);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingArticle = _articleRepository.GetArticleById(id);
            if (existingArticle == null)
            {
                return NotFound();
            }
            _articleRepository.DeleteArticle(id);
            return NoContent();
        }

        [HttpGet("int/{id:int}")]
        public IActionResult ProcessArticle(int id)
        {
            _articleService.Accept(_articleVisitor, id);
            var article = _articleRepository.GetArticleById(id);
            if (article == null)
            {
                return NotFound();
            }
            return Ok(article);
        }
    }
}