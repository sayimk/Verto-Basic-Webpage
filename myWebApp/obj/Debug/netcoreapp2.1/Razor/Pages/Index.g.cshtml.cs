#pragma checksum "C:\Users\sayim\myWebApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "908bb6f9e9b2b6b0ee4056925d24f6e99556384f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(myWebApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(myWebApp.Pages.Pages_Index), null)]
namespace myWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\sayim\myWebApp\Pages\_ViewImports.cshtml"
using myWebApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"908bb6f9e9b2b6b0ee4056925d24f6e99556384f", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"721989a388ce7a3f056d1e9ef37c2e43a92d4382", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\sayim\myWebApp\Pages\Index.cshtml"
  
    ViewData["Title"] = "Opticron";

#line default
#line hidden
            BeginContext(51, 46, true);
            WriteLiteral("\r\n<html class=\"no-js\" lang=\"en\" dir=\"ltr\">\r\n  ");
            EndContext();
            BeginContext(97, 312, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e2f5f7271aa4f75a46f491d4aa133b9", async() => {
                BeginContext(103, 299, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""x-ua-compatible"" content=""ie=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Opticron</title>
    <link rel=""stylesheet"" href=""css/foundation.css"">
    <link rel=""stylesheet"" href=""css/app.css"">
  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(409, 4, true);
            WriteLiteral("\r\n  ");
            EndContext();
            BeginContext(413, 6849, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7cead2409e644fd90783da536f6e3f9", async() => {
                BeginContext(419, 6836, true);
                WriteLiteral(@"
    
	<div class=""top-bar"">
	    <div class=""grid-x grid-padding-x align-center"">
			<div class=""cell large-offset-1"">
				<h3>Opticron</h3>
			</div>
		
			
			<div class=""large-auto cell large-offset-1"">
				<h6 style=""font-size:0.875em;"">Our Products</h6>
			</div>
			
			<div class=""large-auto cell"">
				<h6 style=""font-size:0.875em;"">Where to Buy</h6>
			</div>

			<div class=""large-auto cell"">
				<h6 style=""font-size:0.875em;"">News & Reviews</h6>
			</div>

			<div class=""large-auto cell"">
				<h6 style=""font-size:0.875em;"">Help & Support</h6>
			</div>

			<div class=""large-auto cell"">
				<h6 style=""font-size:0.875em;"">My Opticron</h6>
			</div>

			<div class=""large-4 cell"">
				<ul class=""menu"">
					<li><input type =""search"" placeholder=""Search""></li>
					<li><button type=""button"" class=""button"">Search</button></li>
				</ul>
			</div>
		</div>
	</div>



	<div class=""orbit"" role=""region"" aria-label=""Favorite Space Pictures"" data-orbit>
  <div class=""orbi");
                WriteLiteral(@"t-wrapper"">

    <div class=""orbit-controls"">
      <button class=""orbit-previous""><span class=""show-for-sr"">Previous Slide</span>&#9664;&#xFE0E;</button>
      <button class=""orbit-next""><span class=""show-for-sr"">Next Slide</span>&#9654;&#xFE0E;</button>
    </div>

    <ul class=""orbit-container"">
      <li class=""is-active orbit-slide"">
        <figure class=""orbit-figure"">
          <img class=""orbit-image"" src=""https://www.freewebheaders.com/wp-content/gallery/forests-fields/grass-hills-and-colorful-summer-flowers-field-website-header.jpg"" alt=""summer flowers"">
          <figcaption class=""orbit-caption"">Field of Roses. + grassy hills from Windows XP Bliss</figcaption>
        </figure>
      </li>

      <li class=""orbit-slide"">
        <figure class=""orbit-figure"">
          <img class=""orbit-image"" src=""https://www.freewebheaders.com/wp-content/gallery/mountains-snow/snow-mountains-blue-sky-and-lake-panoramic-web-header-.jpg"" alt=""sky"">
          <figcaption class=""orbit-caption"">Bea");
                WriteLiteral(@"utiful Mountain Range, Alps?</figcaption>
        </figure>
      </li>

      <li class=""orbit-slide"">
        <figure class=""orbit-figure"">
          <img class=""orbit-image"" src=""https://www.freewebheaders.com/wp-content/gallery/plants-cactus/amazing-beautiful-pino-enano-pine-plant-field-header.jpg"" alt=""field"">
          <figcaption class=""orbit-caption"">Open and rocky Fields, + Lake?</figcaption>
        </figure>
      </li>

      <li class=""orbit-slide"">
        <figure class=""orbit-figure"">
          <img class=""orbit-image"" src=""https://cdn.pixabay.com/photo/2017/10/03/17/53/nature-2813487_1280.jpg"" alt=""wooden houses"">
          <figcaption class=""orbit-caption"">A small Farm area, with sheds</figcaption>
        </figure>
      </li>

	  <li class=""orbit-slide"">
        <figure class=""orbit-figure"">
          <img class=""orbit-image"" src=""https://png.pngtree.com/thumb_back/fw800/back_pic/00/02/55/065618d5d6db7c6.jpg"" alt=""cityscape"">
          <figcaption class=""orbit-caption"">");
                WriteLiteral(@"The City life, Full of People and Cars</figcaption>
        </figure>
      </li>

    </ul>
  </div>

  <nav class=""orbit-bullets"">
    <button class=""is-active"" data-slide=""0"">
      <span class=""show-for-sr"">First slide details.</span>
      <span class=""show-for-sr"" data-slide-active-label>Current Slide</span>
    </button>
    <button data-slide=""1""><span class=""show-for-sr"">Second slide details.</span></button>
    <button data-slide=""2""><span class=""show-for-sr"">Third slide details.</span></button>
    <button data-slide=""3""><span class=""show-for-sr"">Fourth slide details.</span></button>
	<button data-slide=""4""><span class=""show-for-sr"">Fifth slide details.</span></button>

  </nav>
</div>




<div class=""grid-x grid-padding-x align-center"">

	<div class=""large-2 cell"">
		<h4>New Products</h4>
		<img src=""https://i0.wp.com/www.birdsandblossom.com/wp-content/uploads/2018/09/Bee-Hummingbird.png?fit=762%2C509&ssl=1"">
		<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
                WriteLiteral(@" 
		Nam nibh lorem, sagittis in leo vitae, luctus rhoncus ipsum. 
		Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.</p>
	</div>

	<div class=""large-2 cell"">
		<h4>Field Events</h4>
		<img src=""https://www.ikonphotography.co.uk/wp-content/uploads/2018/09/pexels-photo-408518-970x648.jpeg"">
		<p>Nulla dapibus ornare ultrices. 
		Etiam placerat vestibulum leo non consequat. 
		Phasellus convallis auctor sagittis. 
		Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>
	</div>

	<div class=""large-2 cell"">
		<h4>Latest News</h4>
		<img src=""https://live.staticflickr.com/7067/6805873452_c43b354c2a_b.jpg"">
		<p>Pellentesque vulputate ligula eu massa vulputate, 
		eget rhoncus nulla euismod. Duis rhoncus at lorem a placerat.</p>
		
	</div>

	<div class=""large-2 cell"">
		<h4>Gallery</h4>
		<img src=""https://www.metaslider.com/wp-content/uploads/2014/08/tumblr_n9hym20RNy1st5lhmo1_1280.jpg"">
		<p>Donec in fringilla eros, mattis convallis ");
                WriteLiteral(@"mauris. 
		Vivamus scelerisque, eros at mattis sagittis, sapien dui iaculis quam, 
		sed consequat risus est a turpis.</p>
	</div>

</div>

<div class=""grid-x grid-margin-x align-center"">
	<div class=""medium-2 cell"">
		<button type=""button"" class=""success button"">New Products</button>
	</div>

	<div class=""medium-2 cell"">
		<button type=""button"" class=""success button"">Field Events</button>
	</div>

	<div class=""medium-2 cell"">
		<button type=""button"" class=""success button"">Latest News</button>
	</div>

	<div class=""medium-2 cell"">
		<button type=""button"" class=""success button"">View Gallery</button>
	</div>
</div>

<br/>

<div class=""grid-x grid-padding-x align-center"">

	<div class=""cell"">
		<h4 class=""text-center"">Special Offers</h4>
	</div>

	<div class=""large-2 cell"">
		<img src=""https://i0.wp.com/www.birdsandblossom.com/wp-content/uploads/2018/09/Bee-Hummingbird.png?fit=762%2C509&ssl=1"">
		<p class=""text-center"">Blah Blah Blah</p>
	</div>

	<div class=""large-2 cell"">");
                WriteLiteral(@"
		<img src=""https://www.ikonphotography.co.uk/wp-content/uploads/2018/09/pexels-photo-408518-970x648.jpeg"">
		<p class=""text-center"">Blah Blah Blah</p>
	</div>

	<div class=""large-2 cell"">
		<img src=""https://live.staticflickr.com/7067/6805873452_c43b354c2a_b.jpg"">
		<p class=""text-center"">Blah Blah Blah</p>
	</div>
</div>

<div class=""grid-x align-center"">
		<div class=""large-1 cell"">
			<button type=""button"" class=""success button"">View All Offers</button>
		</div>
</div>

    <script src=""js/vendor/jquery.js""></script>
    <script src=""js/vendor/what-input.js""></script>
    <script src=""js/vendor/foundation.js""></script>
    <script src=""js/app.js""></script>
  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7262, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index>)PageContext?.ViewData;
        public Pages_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
