using Swashbuckle.AspNetCore.SwaggerGen;

namespace LowerCaseSwaggerDocumentPaths.Extensions
{
	public static class SwaggerGenOptionsExtensions
	{
		public static SwaggerGenOptions LowerCasePaths(this SwaggerGenOptions @this)
		{
			@this.DocumentFilter<LowerCaseDocumentFilter>();

			return @this;
		}
	}
}
