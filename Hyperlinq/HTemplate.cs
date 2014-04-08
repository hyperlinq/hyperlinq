

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Hyperlinq.Imp;

namespace Hyperlinq
{    
    public static class H
    {
		/// <summary>
        /// Defines a hyperlink.
        /// </summary>
        
		public static HElement a (params object[] children) { return new HElement ("a", null, children); }
        
		/// <summary>
        /// Defines a hyperlink.
        /// </summary>
		public static HElement a (ChainFunc<HAttributes.a> attributes, params object[] children) { return new HElement ("a", attributes (null), children); }        

		/// <summary>
        /// Defines an abbreviation.
        /// </summary>
        
		public static HElement abbr (params object[] children) { return new HElement ("abbr", null, children); }
        
		/// <summary>
        /// Defines an abbreviation.
        /// </summary>
		public static HElement abbr (ChainFunc<HAttributes.abbr> attributes, params object[] children) { return new HElement ("abbr", attributes (null), children); }        

		/// <summary>
        /// Not supported in HTML5. Defines an acronym.
        /// </summary>
        
		public static HElement acronym (params object[] children) { return new HElement ("acronym", null, children); }
        
		/// <summary>
        /// Not supported in HTML5. Defines an acronym.
        /// </summary>
		public static HElement acronym (ChainFunc<HAttributes.acronym> attributes, params object[] children) { return new HElement ("acronym", attributes (null), children); }        

		/// <summary>
        /// Defines contact information for the author/owner of a document.
        /// </summary>
        
		public static HElement address (params object[] children) { return new HElement ("address", null, children); }
        
		/// <summary>
        /// Defines contact information for the author/owner of a document.
        /// </summary>
		public static HElement address (ChainFunc<HAttributes.address> attributes, params object[] children) { return new HElement ("address", attributes (null), children); }        

		/// <summary>
        /// Not supported in HTML5. Deprecated in HTML 4.01. Defines an embedded applet.
        /// </summary>
        
		public static HElement applet (params object[] children) { return new HElement ("applet", null, children); }
        
		/// <summary>
        /// Not supported in HTML5. Deprecated in HTML 4.01. Defines an embedded applet.
        /// </summary>
		public static HElement applet (ChainFunc<HAttributes.applet> attributes, params object[] children) { return new HElement ("applet", attributes (null), children); }        

		/// <summary>
        /// Defines an area inside an image-map.
        /// </summary>
        
		public static HElement area (params object[] children) { return new HElement ("area", null, children); }
        
		/// <summary>
        /// Defines an area inside an image-map.
        /// </summary>
		public static HElement area (ChainFunc<HAttributes.area> attributes, params object[] children) { return new HElement ("area", attributes (null), children); }        

		/// <summary>
        /// Defines an article.
        /// </summary>
        
		public static HElement article (params object[] children) { return new HElement ("article", null, children); }
        
		/// <summary>
        /// Defines an article.
        /// </summary>
		public static HElement article (ChainFunc<HAttributes.article> attributes, params object[] children) { return new HElement ("article", attributes (null), children); }        

		/// <summary>
        /// Defines content aside from the page content.
        /// </summary>
        
		public static HElement aside (params object[] children) { return new HElement ("aside", null, children); }
        
		/// <summary>
        /// Defines content aside from the page content.
        /// </summary>
		public static HElement aside (ChainFunc<HAttributes.aside> attributes, params object[] children) { return new HElement ("aside", attributes (null), children); }        

		/// <summary>
        /// Defines sound content.
        /// </summary>
        
		public static HElement audio (params object[] children) { return new HElement ("audio", null, children); }
        
		/// <summary>
        /// Defines sound content.
        /// </summary>
		public static HElement audio (ChainFunc<HAttributes.audio> attributes, params object[] children) { return new HElement ("audio", attributes (null), children); }        

		/// <summary>
        /// Defines bold text.
        /// </summary>
        
		public static HElement b (params object[] children) { return new HElement ("b", null, children); }
        
		/// <summary>
        /// Defines bold text.
        /// </summary>
		public static HElement b (ChainFunc<HAttributes.b> attributes, params object[] children) { return new HElement ("b", attributes (null), children); }        

		/// <summary>
        /// Specifies the base URL/target for all relative URLs in a document.
        /// </summary>
        
		public static HElement @base (params object[] children) { return new HElement ("base", null, children); }
        
		/// <summary>
        /// Specifies the base URL/target for all relative URLs in a document.
        /// </summary>
		public static HElement @base (ChainFunc<HAttributes.@base> attributes, params object[] children) { return new HElement ("base", attributes (null), children); }        

		/// <summary>
        /// Not supported in HTML5. Deprecated in HTML 4.01. Specifies a default colour, size, and font for all text in a document.
        /// </summary>
        
		public static HElement basefont (params object[] children) { return new HElement ("basefont", null, children); }
        
		/// <summary>
        /// Not supported in HTML5. Deprecated in HTML 4.01. Specifies a default colour, size, and font for all text in a document.
        /// </summary>
		public static HElement basefont (ChainFunc<HAttributes.basefont> attributes, params object[] children) { return new HElement ("basefont", attributes (null), children); }        

		/// <summary>
        /// Isolates a part of text that might be formatted in a different direction from other text outside it.
        /// </summary>
        
		public static HElement bdi (params object[] children) { return new HElement ("bdi", null, children); }
        
		/// <summary>
        /// Isolates a part of text that might be formatted in a different direction from other text outside it.
        /// </summary>
		public static HElement bdi (ChainFunc<HAttributes.bdi> attributes, params object[] children) { return new HElement ("bdi", attributes (null), children); }        

		/// <summary>
        /// Overrides the current text direction.
        /// </summary>
        
		public static HElement bdo (params object[] children) { return new HElement ("bdo", null, children); }
        
		/// <summary>
        /// Overrides the current text direction.
        /// </summary>
		public static HElement bdo (ChainFunc<HAttributes.bdo> attributes, params object[] children) { return new HElement ("bdo", attributes (null), children); }        

		/// <summary>
        /// Not supported in HTML5. Defines big text.
        /// </summary>
        
		public static HElement big (params object[] children) { return new HElement ("big", null, children); }
        
		/// <summary>
        /// Not supported in HTML5. Defines big text.
        /// </summary>
		public static HElement big (ChainFunc<HAttributes.big> attributes, params object[] children) { return new HElement ("big", attributes (null), children); }        

		/// <summary>
        /// Defines a section that is quoted from another source.
        /// </summary>
        
		public static HElement blockquote (params object[] children) { return new HElement ("blockquote", null, children); }
        
		/// <summary>
        /// Defines a section that is quoted from another source.
        /// </summary>
		public static HElement blockquote (ChainFunc<HAttributes.blockquote> attributes, params object[] children) { return new HElement ("blockquote", attributes (null), children); }        

		/// <summary>
        /// Defines the document's body.
        /// </summary>
        
		public static HElement body (params object[] children) { return new HElement ("body", null, children); }
        
		/// <summary>
        /// Defines the document's body.
        /// </summary>
		public static HElement body (ChainFunc<HAttributes.body> attributes, params object[] children) { return new HElement ("body", attributes (null), children); }        

		/// <summary>
        /// Defines a single line break.
        /// </summary>
        
		public static HElement br (params object[] children) { return new HElement ("br", null, children); }
        
		/// <summary>
        /// Defines a single line break.
        /// </summary>
		public static HElement br (ChainFunc<HAttributes.br> attributes, params object[] children) { return new HElement ("br", attributes (null), children); }        

		/// <summary>
        /// Used to draw graphics, on the fly, via scripting (usually JavaScript).
        /// </summary>
        
		public static HElement canvas (params object[] children) { return new HElement ("canvas", null, children); }
        
		/// <summary>
        /// Used to draw graphics, on the fly, via scripting (usually JavaScript).
        /// </summary>
		public static HElement canvas (ChainFunc<HAttributes.canvas> attributes, params object[] children) { return new HElement ("canvas", attributes (null), children); }        

		/// <summary>
        /// Defines a table caption.
        /// </summary>
        
		public static HElement caption (params object[] children) { return new HElement ("caption", null, children); }
        
		/// <summary>
        /// Defines a table caption.
        /// </summary>
		public static HElement caption (ChainFunc<HAttributes.caption> attributes, params object[] children) { return new HElement ("caption", attributes (null), children); }        

		/// <summary>
        /// Not supported in HTML5. Deprecated in HTML 4.01. Defines centred text.
        /// </summary>
        
		public static HElement center (params object[] children) { return new HElement ("center", null, children); }
        
		/// <summary>
        /// Not supported in HTML5. Deprecated in HTML 4.01. Defines centred text.
        /// </summary>
		public static HElement center (ChainFunc<HAttributes.center> attributes, params object[] children) { return new HElement ("center", attributes (null), children); }        

		/// <summary>
        /// Defines the title of a work.
        /// </summary>
        
		public static HElement cite (params object[] children) { return new HElement ("cite", null, children); }
        
		/// <summary>
        /// Defines the title of a work.
        /// </summary>
		public static HElement cite (ChainFunc<HAttributes.cite> attributes, params object[] children) { return new HElement ("cite", attributes (null), children); }        

		/// <summary>
        /// Defines a piece of computer code.
        /// </summary>
        
		public static HElement code (params object[] children) { return new HElement ("code", null, children); }
        
		/// <summary>
        /// Defines a piece of computer code.
        /// </summary>
		public static HElement code (ChainFunc<HAttributes.code> attributes, params object[] children) { return new HElement ("code", attributes (null), children); }        

		/// <summary>
        /// Specifies column properties for each column within a <colgroup> element .
        /// </summary>
        
		public static HElement col (params object[] children) { return new HElement ("col", null, children); }
        
		/// <summary>
        /// Specifies column properties for each column within a <colgroup> element .
        /// </summary>
		public static HElement col (ChainFunc<HAttributes.col> attributes, params object[] children) { return new HElement ("col", attributes (null), children); }        

		/// <summary>
        /// Specifies a group of one or more columns in a table for formatting.
        /// </summary>
        
		public static HElement colgroup (params object[] children) { return new HElement ("colgroup", null, children); }
        
		/// <summary>
        /// Specifies a group of one or more columns in a table for formatting.
        /// </summary>
		public static HElement colgroup (ChainFunc<HAttributes.colgroup> attributes, params object[] children) { return new HElement ("colgroup", attributes (null), children); }        

		/// <summary>
        /// Defines a command button that a user can invoke.
        /// </summary>
        
		public static HElement command (params object[] children) { return new HElement ("command", null, children); }
        
		/// <summary>
        /// Defines a command button that a user can invoke.
        /// </summary>
		public static HElement command (ChainFunc<HAttributes.command> attributes, params object[] children) { return new HElement ("command", attributes (null), children); }        

		/// <summary>
        /// Specifies a list of pre-defined options for input controls.
        /// </summary>
        
		public static HElement datalist (params object[] children) { return new HElement ("datalist", null, children); }
        
		/// <summary>
        /// Specifies a list of pre-defined options for input controls.
        /// </summary>
		public static HElement datalist (ChainFunc<HAttributes.datalist> attributes, params object[] children) { return new HElement ("datalist", attributes (null), children); }        

		/// <summary>
        /// Defines a description of an item in a definition list.
        /// </summary>
        
		public static HElement dd (params object[] children) { return new HElement ("dd", null, children); }
        
		/// <summary>
        /// Defines a description of an item in a definition list.
        /// </summary>
		public static HElement dd (ChainFunc<HAttributes.dd> attributes, params object[] children) { return new HElement ("dd", attributes (null), children); }        

		/// <summary>
        /// Defines text that has been deleted from a document.
        /// </summary>
        
		public static HElement del (params object[] children) { return new HElement ("del", null, children); }
        
		/// <summary>
        /// Defines text that has been deleted from a document.
        /// </summary>
		public static HElement del (ChainFunc<HAttributes.del> attributes, params object[] children) { return new HElement ("del", attributes (null), children); }        

		/// <summary>
        /// Defines additional details that the user can view or hide.
        /// </summary>
        
		public static HElement details (params object[] children) { return new HElement ("details", null, children); }
        
		/// <summary>
        /// Defines additional details that the user can view or hide.
        /// </summary>
		public static HElement details (ChainFunc<HAttributes.details> attributes, params object[] children) { return new HElement ("details", attributes (null), children); }        

		/// <summary>
        /// Defines a definition term.
        /// </summary>
        
		public static HElement dfn (params object[] children) { return new HElement ("dfn", null, children); }
        
		/// <summary>
        /// Defines a definition term.
        /// </summary>
		public static HElement dfn (ChainFunc<HAttributes.dfn> attributes, params object[] children) { return new HElement ("dfn", attributes (null), children); }        

		/// <summary>
        /// Defines a dialog box or window.
        /// </summary>
        
		public static HElement dialog (params object[] children) { return new HElement ("dialog", null, children); }
        
		/// <summary>
        /// Defines a dialog box or window.
        /// </summary>
		public static HElement dialog (ChainFunc<HAttributes.dialog> attributes, params object[] children) { return new HElement ("dialog", attributes (null), children); }        

		/// <summary>
        /// Not supported in HTML5. Deprecated in HTML 4.01. Defines a directory list.
        /// </summary>
        
		public static HElement dir (params object[] children) { return new HElement ("dir", null, children); }
        
		/// <summary>
        /// Not supported in HTML5. Deprecated in HTML 4.01. Defines a directory list.
        /// </summary>
		public static HElement dir (ChainFunc<HAttributes.dir> attributes, params object[] children) { return new HElement ("dir", attributes (null), children); }        

		/// <summary>
        /// Defines a section in a document.
        /// </summary>
        
		public static HElement div (params object[] children) { return new HElement ("div", null, children); }
        
		/// <summary>
        /// Defines a section in a document.
        /// </summary>
		public static HElement div (ChainFunc<HAttributes.div> attributes, params object[] children) { return new HElement ("div", attributes (null), children); }        

		/// <summary>
        /// Defines a definition list.
        /// </summary>
        
		public static HElement dl (params object[] children) { return new HElement ("dl", null, children); }
        
		/// <summary>
        /// Defines a definition list.
        /// </summary>
		public static HElement dl (ChainFunc<HAttributes.dl> attributes, params object[] children) { return new HElement ("dl", attributes (null), children); }        

		/// <summary>
        /// Defines a term (an item) in a definition list.
        /// </summary>
        
		public static HElement dt (params object[] children) { return new HElement ("dt", null, children); }
        
		/// <summary>
        /// Defines a term (an item) in a definition list.
        /// </summary>
		public static HElement dt (ChainFunc<HAttributes.dt> attributes, params object[] children) { return new HElement ("dt", attributes (null), children); }        

		/// <summary>
        /// Defines emphasized text .
        /// </summary>
        
		public static HElement em (params object[] children) { return new HElement ("em", null, children); }
        
		/// <summary>
        /// Defines emphasized text .
        /// </summary>
		public static HElement em (ChainFunc<HAttributes.em> attributes, params object[] children) { return new HElement ("em", attributes (null), children); }        

		/// <summary>
        /// Defines a container for an external (non-HTML) application.
        /// </summary>
        
		public static HElement embed (params object[] children) { return new HElement ("embed", null, children); }
        
		/// <summary>
        /// Defines a container for an external (non-HTML) application.
        /// </summary>
		public static HElement embed (ChainFunc<HAttributes.embed> attributes, params object[] children) { return new HElement ("embed", attributes (null), children); }        

		/// <summary>
        /// Groups related elements in a form.
        /// </summary>
        
		public static HElement fieldset (params object[] children) { return new HElement ("fieldset", null, children); }
        
		/// <summary>
        /// Groups related elements in a form.
        /// </summary>
		public static HElement fieldset (ChainFunc<HAttributes.fieldset> attributes, params object[] children) { return new HElement ("fieldset", attributes (null), children); }        

		/// <summary>
        /// Defines a caption for a <figure> element.
        /// </summary>
        
		public static HElement figcaption (params object[] children) { return new HElement ("figcaption", null, children); }
        
		/// <summary>
        /// Defines a caption for a <figure> element.
        /// </summary>
		public static HElement figcaption (ChainFunc<HAttributes.figcaption> attributes, params object[] children) { return new HElement ("figcaption", attributes (null), children); }        

		/// <summary>
        /// Specifies self-contained content.
        /// </summary>
        
		public static HElement figure (params object[] children) { return new HElement ("figure", null, children); }
        
		/// <summary>
        /// Specifies self-contained content.
        /// </summary>
		public static HElement figure (ChainFunc<HAttributes.figure> attributes, params object[] children) { return new HElement ("figure", attributes (null), children); }        

		/// <summary>
        /// Not supported in HTML5. Deprecated in HTML 4.01. Defines font, colour, and size for text.
        /// </summary>
        
		public static HElement font (params object[] children) { return new HElement ("font", null, children); }
        
		/// <summary>
        /// Not supported in HTML5. Deprecated in HTML 4.01. Defines font, colour, and size for text.
        /// </summary>
		public static HElement font (ChainFunc<HAttributes.font> attributes, params object[] children) { return new HElement ("font", attributes (null), children); }        

		/// <summary>
        /// Defines a footer for a document or section.
        /// </summary>
        
		public static HElement footer (params object[] children) { return new HElement ("footer", null, children); }
        
		/// <summary>
        /// Defines a footer for a document or section.
        /// </summary>
		public static HElement footer (ChainFunc<HAttributes.footer> attributes, params object[] children) { return new HElement ("footer", attributes (null), children); }        

		/// <summary>
        /// Defines an HTML form for user input.
        /// </summary>
        
		public static HElement form (params object[] children) { return new HElement ("form", null, children); }
        
		/// <summary>
        /// Defines an HTML form for user input.
        /// </summary>
		public static HElement form (ChainFunc<HAttributes.form> attributes, params object[] children) { return new HElement ("form", attributes (null), children); }        

		/// <summary>
        /// Not supported in HTML5. Defines a window (a frame) in a frameset.
        /// </summary>
        
		public static HElement frame (params object[] children) { return new HElement ("frame", null, children); }
        
		/// <summary>
        /// Not supported in HTML5. Defines a window (a frame) in a frameset.
        /// </summary>
		public static HElement frame (ChainFunc<HAttributes.frame> attributes, params object[] children) { return new HElement ("frame", attributes (null), children); }        

		/// <summary>
        /// Not supported in HTML5. Defines a set of frames.
        /// </summary>
        
		public static HElement frameset (params object[] children) { return new HElement ("frameset", null, children); }
        
		/// <summary>
        /// Not supported in HTML5. Defines a set of frames.
        /// </summary>
		public static HElement frameset (ChainFunc<HAttributes.frameset> attributes, params object[] children) { return new HElement ("frameset", attributes (null), children); }        

		/// <summary>
        /// Defines HTML headings.
        /// </summary>
        
		public static HElement h1 (params object[] children) { return new HElement ("h1", null, children); }
        
		/// <summary>
        /// Defines HTML headings.
        /// </summary>
		public static HElement h1 (ChainFunc<HAttributes.h1> attributes, params object[] children) { return new HElement ("h1", attributes (null), children); }        

		/// <summary>
        /// Defines HTML headings.
        /// </summary>
        
		public static HElement h2 (params object[] children) { return new HElement ("h2", null, children); }
        
		/// <summary>
        /// Defines HTML headings.
        /// </summary>
		public static HElement h2 (ChainFunc<HAttributes.h2> attributes, params object[] children) { return new HElement ("h2", attributes (null), children); }        

		/// <summary>
        /// Defines HTML headings.
        /// </summary>
        
		public static HElement h3 (params object[] children) { return new HElement ("h3", null, children); }
        
		/// <summary>
        /// Defines HTML headings.
        /// </summary>
		public static HElement h3 (ChainFunc<HAttributes.h3> attributes, params object[] children) { return new HElement ("h3", attributes (null), children); }        

		/// <summary>
        /// Defines HTML headings.
        /// </summary>
        
		public static HElement h4 (params object[] children) { return new HElement ("h4", null, children); }
        
		/// <summary>
        /// Defines HTML headings.
        /// </summary>
		public static HElement h4 (ChainFunc<HAttributes.h4> attributes, params object[] children) { return new HElement ("h4", attributes (null), children); }        

		/// <summary>
        /// Defines HTML headings.
        /// </summary>
        
		public static HElement h5 (params object[] children) { return new HElement ("h5", null, children); }
        
		/// <summary>
        /// Defines HTML headings.
        /// </summary>
		public static HElement h5 (ChainFunc<HAttributes.h5> attributes, params object[] children) { return new HElement ("h5", attributes (null), children); }        

		/// <summary>
        /// Defines HTML headings.
        /// </summary>
        
		public static HElement h6 (params object[] children) { return new HElement ("h6", null, children); }
        
		/// <summary>
        /// Defines HTML headings.
        /// </summary>
		public static HElement h6 (ChainFunc<HAttributes.h6> attributes, params object[] children) { return new HElement ("h6", attributes (null), children); }        

		/// <summary>
        /// Defines information about the document.
        /// </summary>
        
		public static HElement head (params object[] children) { return new HElement ("head", null, children); }
        
		/// <summary>
        /// Defines information about the document.
        /// </summary>
		public static HElement head (ChainFunc<HAttributes.head> attributes, params object[] children) { return new HElement ("head", attributes (null), children); }        

		/// <summary>
        /// Defines a header for a document or section.
        /// </summary>
        
		public static HElement header (params object[] children) { return new HElement ("header", null, children); }
        
		/// <summary>
        /// Defines a header for a document or section.
        /// </summary>
		public static HElement header (ChainFunc<HAttributes.header> attributes, params object[] children) { return new HElement ("header", attributes (null), children); }        

		/// <summary>
        /// Groups heading (<h1> to <h6>) elements.
        /// </summary>
        
		public static HElement hgroup (params object[] children) { return new HElement ("hgroup", null, children); }
        
		/// <summary>
        /// Groups heading (<h1> to <h6>) elements.
        /// </summary>
		public static HElement hgroup (ChainFunc<HAttributes.hgroup> attributes, params object[] children) { return new HElement ("hgroup", attributes (null), children); }        

		/// <summary>
        /// Defines a thematic change in the content.
        /// </summary>
        
		public static HElement hr (params object[] children) { return new HElement ("hr", null, children); }
        
		/// <summary>
        /// Defines a thematic change in the content.
        /// </summary>
		public static HElement hr (ChainFunc<HAttributes.hr> attributes, params object[] children) { return new HElement ("hr", attributes (null), children); }        

		/// <summary>
        /// Defines the root of an HTML document.
        /// </summary>
        
		public static HElement html (params object[] children) { return new HElement ("html", null, children); }
        
		/// <summary>
        /// Defines the root of an HTML document.
        /// </summary>
		public static HElement html (ChainFunc<HAttributes.html> attributes, params object[] children) { return new HElement ("html", attributes (null), children); }        

		/// <summary>
        /// Defines a part of text in an alternate voice or mood.
        /// </summary>
        
		public static HElement i (params object[] children) { return new HElement ("i", null, children); }
        
		/// <summary>
        /// Defines a part of text in an alternate voice or mood.
        /// </summary>
		public static HElement i (ChainFunc<HAttributes.i> attributes, params object[] children) { return new HElement ("i", attributes (null), children); }        

		/// <summary>
        /// Defines an inline frame.
        /// </summary>
        
		public static HElement iframe (params object[] children) { return new HElement ("iframe", null, children); }
        
		/// <summary>
        /// Defines an inline frame.
        /// </summary>
		public static HElement iframe (ChainFunc<HAttributes.iframe> attributes, params object[] children) { return new HElement ("iframe", attributes (null), children); }        

		/// <summary>
        /// Defines an image.
        /// </summary>
        
		public static HElement img (params object[] children) { return new HElement ("img", null, children); }
        
		/// <summary>
        /// Defines an image.
        /// </summary>
		public static HElement img (ChainFunc<HAttributes.img> attributes, params object[] children) { return new HElement ("img", attributes (null), children); }        

		/// <summary>
        /// Defines an input control.
        /// </summary>
        
		public static HElement input (params object[] children) { return new HElement ("input", null, children); }
        
		/// <summary>
        /// Defines an input control.
        /// </summary>
		public static HElement input (ChainFunc<HAttributes.input> attributes, params object[] children) { return new HElement ("input", attributes (null), children); }        

		/// <summary>
        /// Defines a text that has been inserted into a document.
        /// </summary>
        
		public static HElement ins (params object[] children) { return new HElement ("ins", null, children); }
        
		/// <summary>
        /// Defines a text that has been inserted into a document.
        /// </summary>
		public static HElement ins (ChainFunc<HAttributes.ins> attributes, params object[] children) { return new HElement ("ins", attributes (null), children); }        

		/// <summary>
        /// Defines keyboard input.
        /// </summary>
        
		public static HElement kbd (params object[] children) { return new HElement ("kbd", null, children); }
        
		/// <summary>
        /// Defines keyboard input.
        /// </summary>
		public static HElement kbd (ChainFunc<HAttributes.kbd> attributes, params object[] children) { return new HElement ("kbd", attributes (null), children); }        

		/// <summary>
        /// Defines a key-pair generator field (for forms).
        /// </summary>
        
		public static HElement keygen (params object[] children) { return new HElement ("keygen", null, children); }
        
		/// <summary>
        /// Defines a key-pair generator field (for forms).
        /// </summary>
		public static HElement keygen (ChainFunc<HAttributes.keygen> attributes, params object[] children) { return new HElement ("keygen", attributes (null), children); }        

		/// <summary>
        /// Defines a label for an <input> element.
        /// </summary>
        
		public static HElement label (params object[] children) { return new HElement ("label", null, children); }
        
		/// <summary>
        /// Defines a label for an <input> element.
        /// </summary>
		public static HElement label (ChainFunc<HAttributes.label> attributes, params object[] children) { return new HElement ("label", attributes (null), children); }        

		/// <summary>
        /// Defines a caption for a <fieldset>, < figure>, or <details> element.
        /// </summary>
        
		public static HElement legend (params object[] children) { return new HElement ("legend", null, children); }
        
		/// <summary>
        /// Defines a caption for a <fieldset>, < figure>, or <details> element.
        /// </summary>
		public static HElement legend (ChainFunc<HAttributes.legend> attributes, params object[] children) { return new HElement ("legend", attributes (null), children); }        

		/// <summary>
        /// Defines a list item.
        /// </summary>
        
		public static HElement li (params object[] children) { return new HElement ("li", null, children); }
        
		/// <summary>
        /// Defines a list item.
        /// </summary>
		public static HElement li (ChainFunc<HAttributes.li> attributes, params object[] children) { return new HElement ("li", attributes (null), children); }        

		/// <summary>
        /// Defines the relationship between a document and an external resource (most used to link to style sheets).
        /// </summary>
        
		public static HElement link (params object[] children) { return new HElement ("link", null, children); }
        
		/// <summary>
        /// Defines the relationship between a document and an external resource (most used to link to style sheets).
        /// </summary>
		public static HElement link (ChainFunc<HAttributes.link> attributes, params object[] children) { return new HElement ("link", attributes (null), children); }        

		/// <summary>
        /// Defines a client-side image-map.
        /// </summary>
        
		public static HElement map (params object[] children) { return new HElement ("map", null, children); }
        
		/// <summary>
        /// Defines a client-side image-map.
        /// </summary>
		public static HElement map (ChainFunc<HAttributes.map> attributes, params object[] children) { return new HElement ("map", attributes (null), children); }        

		/// <summary>
        /// Defines marked/highlighted text.
        /// </summary>
        
		public static HElement mark (params object[] children) { return new HElement ("mark", null, children); }
        
		/// <summary>
        /// Defines marked/highlighted text.
        /// </summary>
		public static HElement mark (ChainFunc<HAttributes.mark> attributes, params object[] children) { return new HElement ("mark", attributes (null), children); }        

		/// <summary>
        /// Defines a list/menu of commands.
        /// </summary>
        
		public static HElement menu (params object[] children) { return new HElement ("menu", null, children); }
        
		/// <summary>
        /// Defines a list/menu of commands.
        /// </summary>
		public static HElement menu (ChainFunc<HAttributes.menu> attributes, params object[] children) { return new HElement ("menu", attributes (null), children); }        

		/// <summary>
        /// Defines metadata about an HTML document.
        /// </summary>
        
		public static HElement meta (params object[] children) { return new HElement ("meta", null, children); }
        
		/// <summary>
        /// Defines metadata about an HTML document.
        /// </summary>
		public static HElement meta (ChainFunc<HAttributes.meta> attributes, params object[] children) { return new HElement ("meta", attributes (null), children); }        

		/// <summary>
        /// Defines a scalar measurement within a known range (a gauge).
        /// </summary>
        
		public static HElement meter (params object[] children) { return new HElement ("meter", null, children); }
        
		/// <summary>
        /// Defines a scalar measurement within a known range (a gauge).
        /// </summary>
		public static HElement meter (ChainFunc<HAttributes.meter> attributes, params object[] children) { return new HElement ("meter", attributes (null), children); }        

		/// <summary>
        /// Defines navigation links.
        /// </summary>
        
		public static HElement nav (params object[] children) { return new HElement ("nav", null, children); }
        
		/// <summary>
        /// Defines navigation links.
        /// </summary>
		public static HElement nav (ChainFunc<HAttributes.nav> attributes, params object[] children) { return new HElement ("nav", attributes (null), children); }        

		/// <summary>
        /// Not supported in HTML5. Defines an alternate content for users that do not support frames.
        /// </summary>
        
		public static HElement noframes (params object[] children) { return new HElement ("noframes", null, children); }
        
		/// <summary>
        /// Not supported in HTML5. Defines an alternate content for users that do not support frames.
        /// </summary>
		public static HElement noframes (ChainFunc<HAttributes.noframes> attributes, params object[] children) { return new HElement ("noframes", attributes (null), children); }        

		/// <summary>
        /// Defines an alternate content for users that do not support client-side scripts.
        /// </summary>
        
		public static HElement noscript (params object[] children) { return new HElement ("noscript", null, children); }
        
		/// <summary>
        /// Defines an alternate content for users that do not support client-side scripts.
        /// </summary>
		public static HElement noscript (ChainFunc<HAttributes.noscript> attributes, params object[] children) { return new HElement ("noscript", attributes (null), children); }        

		/// <summary>
        /// Defines an embedded object.
        /// </summary>
        
		public static HElement @object (params object[] children) { return new HElement ("object", null, children); }
        
		/// <summary>
        /// Defines an embedded object.
        /// </summary>
		public static HElement @object (ChainFunc<HAttributes.@object> attributes, params object[] children) { return new HElement ("object", attributes (null), children); }        

		/// <summary>
        /// Defines an ordered list.
        /// </summary>
        
		public static HElement ol (params object[] children) { return new HElement ("ol", null, children); }
        
		/// <summary>
        /// Defines an ordered list.
        /// </summary>
		public static HElement ol (ChainFunc<HAttributes.ol> attributes, params object[] children) { return new HElement ("ol", attributes (null), children); }        

		/// <summary>
        /// Defines a group of related options in a drop-down list.
        /// </summary>
        
		public static HElement optgroup (params object[] children) { return new HElement ("optgroup", null, children); }
        
		/// <summary>
        /// Defines a group of related options in a drop-down list.
        /// </summary>
		public static HElement optgroup (ChainFunc<HAttributes.optgroup> attributes, params object[] children) { return new HElement ("optgroup", attributes (null), children); }        

		/// <summary>
        /// Defines an option in a drop-down list.
        /// </summary>
        
		public static HElement option (params object[] children) { return new HElement ("option", null, children); }
        
		/// <summary>
        /// Defines an option in a drop-down list.
        /// </summary>
		public static HElement option (ChainFunc<HAttributes.option> attributes, params object[] children) { return new HElement ("option", attributes (null), children); }        

		/// <summary>
        /// Defines the result of a calculation.
        /// </summary>
        
		public static HElement output (params object[] children) { return new HElement ("output", null, children); }
        
		/// <summary>
        /// Defines the result of a calculation.
        /// </summary>
		public static HElement output (ChainFunc<HAttributes.output> attributes, params object[] children) { return new HElement ("output", attributes (null), children); }        

		/// <summary>
        /// Defines a paragraph.
        /// </summary>
        
		public static HElement p (params object[] children) { return new HElement ("p", null, children); }
        
		/// <summary>
        /// Defines a paragraph.
        /// </summary>
		public static HElement p (ChainFunc<HAttributes.p> attributes, params object[] children) { return new HElement ("p", attributes (null), children); }        

		/// <summary>
        /// Defines a parameter for an object.
        /// </summary>
        
		public static HElement param (params object[] children) { return new HElement ("param", null, children); }
        
		/// <summary>
        /// Defines a parameter for an object.
        /// </summary>
		public static HElement param (ChainFunc<HAttributes.param> attributes, params object[] children) { return new HElement ("param", attributes (null), children); }        

		/// <summary>
        /// Defines pre-formatted text.
        /// </summary>
        
		public static HElement pre (params object[] children) { return new HElement ("pre", null, children); }
        
		/// <summary>
        /// Defines pre-formatted text.
        /// </summary>
		public static HElement pre (ChainFunc<HAttributes.pre> attributes, params object[] children) { return new HElement ("pre", attributes (null), children); }        

		/// <summary>
        /// Represents the progress of a task.
        /// </summary>
        
		public static HElement progress (params object[] children) { return new HElement ("progress", null, children); }
        
		/// <summary>
        /// Represents the progress of a task.
        /// </summary>
		public static HElement progress (ChainFunc<HAttributes.progress> attributes, params object[] children) { return new HElement ("progress", attributes (null), children); }        

		/// <summary>
        /// Defines a short quotation.
        /// </summary>
        
		public static HElement q (params object[] children) { return new HElement ("q", null, children); }
        
		/// <summary>
        /// Defines a short quotation.
        /// </summary>
		public static HElement q (ChainFunc<HAttributes.q> attributes, params object[] children) { return new HElement ("q", attributes (null), children); }        

		/// <summary>
        /// Defines what to show in browsers that do not support ruby annotations.
        /// </summary>
        
		public static HElement rp (params object[] children) { return new HElement ("rp", null, children); }
        
		/// <summary>
        /// Defines what to show in browsers that do not support ruby annotations.
        /// </summary>
		public static HElement rp (ChainFunc<HAttributes.rp> attributes, params object[] children) { return new HElement ("rp", attributes (null), children); }        

		/// <summary>
        /// Defines an explanation/pronunciation of characters (for East Asian typography).
        /// </summary>
        
		public static HElement rt (params object[] children) { return new HElement ("rt", null, children); }
        
		/// <summary>
        /// Defines an explanation/pronunciation of characters (for East Asian typography).
        /// </summary>
		public static HElement rt (ChainFunc<HAttributes.rt> attributes, params object[] children) { return new HElement ("rt", attributes (null), children); }        

		/// <summary>
        /// Defines a ruby annotation (for East Asian typography).
        /// </summary>
        
		public static HElement ruby (params object[] children) { return new HElement ("ruby", null, children); }
        
		/// <summary>
        /// Defines a ruby annotation (for East Asian typography).
        /// </summary>
		public static HElement ruby (ChainFunc<HAttributes.ruby> attributes, params object[] children) { return new HElement ("ruby", attributes (null), children); }        

		/// <summary>
        /// Defines text that is no longer correct.
        /// </summary>
        
		public static HElement s (params object[] children) { return new HElement ("s", null, children); }
        
		/// <summary>
        /// Defines text that is no longer correct.
        /// </summary>
		public static HElement s (ChainFunc<HAttributes.s> attributes, params object[] children) { return new HElement ("s", attributes (null), children); }        

		/// <summary>
        /// Defines sample output from a computer program.
        /// </summary>
        
		public static HElement samp (params object[] children) { return new HElement ("samp", null, children); }
        
		/// <summary>
        /// Defines sample output from a computer program.
        /// </summary>
		public static HElement samp (ChainFunc<HAttributes.samp> attributes, params object[] children) { return new HElement ("samp", attributes (null), children); }        

		/// <summary>
        /// Defines a client-side script.
        /// </summary>
        
		public static HElement script (params object[] children) { return new HElement ("script", null, children); }
        
		/// <summary>
        /// Defines a client-side script.
        /// </summary>
		public static HElement script (ChainFunc<HAttributes.script> attributes, params object[] children) { return new HElement ("script", attributes (null), children); }        

		/// <summary>
        /// Defines a section in a document.
        /// </summary>
        
		public static HElement section (params object[] children) { return new HElement ("section", null, children); }
        
		/// <summary>
        /// Defines a section in a document.
        /// </summary>
		public static HElement section (ChainFunc<HAttributes.section> attributes, params object[] children) { return new HElement ("section", attributes (null), children); }        

		/// <summary>
        /// Defines a drop-down list.
        /// </summary>
        
		public static HElement select (params object[] children) { return new HElement ("select", null, children); }
        
		/// <summary>
        /// Defines a drop-down list.
        /// </summary>
		public static HElement select (ChainFunc<HAttributes.select> attributes, params object[] children) { return new HElement ("select", attributes (null), children); }        

		/// <summary>
        /// Defines smaller text.
        /// </summary>
        
		public static HElement small (params object[] children) { return new HElement ("small", null, children); }
        
		/// <summary>
        /// Defines smaller text.
        /// </summary>
		public static HElement small (ChainFunc<HAttributes.small> attributes, params object[] children) { return new HElement ("small", attributes (null), children); }        

		/// <summary>
        /// Defines multiple media resources for media elements (<video> and <audio>).
        /// </summary>
        
		public static HElement source (params object[] children) { return new HElement ("source", null, children); }
        
		/// <summary>
        /// Defines multiple media resources for media elements (<video> and <audio>).
        /// </summary>
		public static HElement source (ChainFunc<HAttributes.source> attributes, params object[] children) { return new HElement ("source", attributes (null), children); }        

		/// <summary>
        /// Defines a section in a document.
        /// </summary>
        
		public static HElement span (params object[] children) { return new HElement ("span", null, children); }
        
		/// <summary>
        /// Defines a section in a document.
        /// </summary>
		public static HElement span (ChainFunc<HAttributes.span> attributes, params object[] children) { return new HElement ("span", attributes (null), children); }        

		/// <summary>
        /// Not supported in HTML5. Deprecated in HTML 4.01. Defines strike-through text.
        /// </summary>
        
		public static HElement strike (params object[] children) { return new HElement ("strike", null, children); }
        
		/// <summary>
        /// Not supported in HTML5. Deprecated in HTML 4.01. Defines strike-through text.
        /// </summary>
		public static HElement strike (ChainFunc<HAttributes.strike> attributes, params object[] children) { return new HElement ("strike", attributes (null), children); }        

		/// <summary>
        /// Defines important text.
        /// </summary>
        
		public static HElement strong (params object[] children) { return new HElement ("strong", null, children); }
        
		/// <summary>
        /// Defines important text.
        /// </summary>
		public static HElement strong (ChainFunc<HAttributes.strong> attributes, params object[] children) { return new HElement ("strong", attributes (null), children); }        

		/// <summary>
        /// Defines style information for a document.
        /// </summary>
        
		public static HElement style (params object[] children) { return new HElement ("style", null, children); }
        
		/// <summary>
        /// Defines style information for a document.
        /// </summary>
		public static HElement style (ChainFunc<HAttributes.style> attributes, params object[] children) { return new HElement ("style", attributes (null), children); }        

		/// <summary>
        /// Defines subscripted text.
        /// </summary>
        
		public static HElement sub (params object[] children) { return new HElement ("sub", null, children); }
        
		/// <summary>
        /// Defines subscripted text.
        /// </summary>
		public static HElement sub (ChainFunc<HAttributes.sub> attributes, params object[] children) { return new HElement ("sub", attributes (null), children); }        

		/// <summary>
        /// Defines a visible heading for a <details> element.
        /// </summary>
        
		public static HElement summary (params object[] children) { return new HElement ("summary", null, children); }
        
		/// <summary>
        /// Defines a visible heading for a <details> element.
        /// </summary>
		public static HElement summary (ChainFunc<HAttributes.summary> attributes, params object[] children) { return new HElement ("summary", attributes (null), children); }        

		/// <summary>
        /// Defines superscripted text.
        /// </summary>
        
		public static HElement sup (params object[] children) { return new HElement ("sup", null, children); }
        
		/// <summary>
        /// Defines superscripted text.
        /// </summary>
		public static HElement sup (ChainFunc<HAttributes.sup> attributes, params object[] children) { return new HElement ("sup", attributes (null), children); }        

		/// <summary>
        /// Defines a table.
        /// </summary>
        
		public static HElement table (params object[] children) { return new HElement ("table", null, children); }
        
		/// <summary>
        /// Defines a table.
        /// </summary>
		public static HElement table (ChainFunc<HAttributes.table> attributes, params object[] children) { return new HElement ("table", attributes (null), children); }        

		/// <summary>
        /// Groups the body content in a table.
        /// </summary>
        
		public static HElement tbody (params object[] children) { return new HElement ("tbody", null, children); }
        
		/// <summary>
        /// Groups the body content in a table.
        /// </summary>
		public static HElement tbody (ChainFunc<HAttributes.tbody> attributes, params object[] children) { return new HElement ("tbody", attributes (null), children); }        

		/// <summary>
        /// Defines a cell in a table.
        /// </summary>
        
		public static HElement td (params object[] children) { return new HElement ("td", null, children); }
        
		/// <summary>
        /// Defines a cell in a table.
        /// </summary>
		public static HElement td (ChainFunc<HAttributes.td> attributes, params object[] children) { return new HElement ("td", attributes (null), children); }        

		/// <summary>
        /// Defines a multi-line input control (text area).
        /// </summary>
        
		public static HElement textarea (params object[] children) { return new HElement ("textarea", null, children); }
        
		/// <summary>
        /// Defines a multi-line input control (text area).
        /// </summary>
		public static HElement textarea (ChainFunc<HAttributes.textarea> attributes, params object[] children) { return new HElement ("textarea", attributes (null), children); }        

		/// <summary>
        /// Groups the footer content in a table.
        /// </summary>
        
		public static HElement tfoot (params object[] children) { return new HElement ("tfoot", null, children); }
        
		/// <summary>
        /// Groups the footer content in a table.
        /// </summary>
		public static HElement tfoot (ChainFunc<HAttributes.tfoot> attributes, params object[] children) { return new HElement ("tfoot", attributes (null), children); }        

		/// <summary>
        /// Defines a header cell in a table.
        /// </summary>
        
		public static HElement th (params object[] children) { return new HElement ("th", null, children); }
        
		/// <summary>
        /// Defines a header cell in a table.
        /// </summary>
		public static HElement th (ChainFunc<HAttributes.th> attributes, params object[] children) { return new HElement ("th", attributes (null), children); }        

		/// <summary>
        /// Groups the header content in a table.
        /// </summary>
        
		public static HElement thead (params object[] children) { return new HElement ("thead", null, children); }
        
		/// <summary>
        /// Groups the header content in a table.
        /// </summary>
		public static HElement thead (ChainFunc<HAttributes.thead> attributes, params object[] children) { return new HElement ("thead", attributes (null), children); }        

		/// <summary>
        /// Defines a date/time.
        /// </summary>
        
		public static HElement time (params object[] children) { return new HElement ("time", null, children); }
        
		/// <summary>
        /// Defines a date/time.
        /// </summary>
		public static HElement time (ChainFunc<HAttributes.time> attributes, params object[] children) { return new HElement ("time", attributes (null), children); }        

		/// <summary>
        /// Defines a title for the document.
        /// </summary>
        
		public static HElement title (params object[] children) { return new HElement ("title", null, children); }
        
		/// <summary>
        /// Defines a title for the document.
        /// </summary>
		public static HElement title (ChainFunc<HAttributes.title> attributes, params object[] children) { return new HElement ("title", attributes (null), children); }        

		/// <summary>
        /// Defines a row in a table.
        /// </summary>
        
		public static HElement tr (params object[] children) { return new HElement ("tr", null, children); }
        
		/// <summary>
        /// Defines a row in a table.
        /// </summary>
		public static HElement tr (ChainFunc<HAttributes.tr> attributes, params object[] children) { return new HElement ("tr", attributes (null), children); }        

		/// <summary>
        /// Defines text tracks for media elements (<video> and <audio>).
        /// </summary>
        
		public static HElement track (params object[] children) { return new HElement ("track", null, children); }
        
		/// <summary>
        /// Defines text tracks for media elements (<video> and <audio>).
        /// </summary>
		public static HElement track (ChainFunc<HAttributes.track> attributes, params object[] children) { return new HElement ("track", attributes (null), children); }        

		/// <summary>
        /// Not supported in HTML5. Defines Teletype text.
        /// </summary>
        
		public static HElement tt (params object[] children) { return new HElement ("tt", null, children); }
        
		/// <summary>
        /// Not supported in HTML5. Defines Teletype text.
        /// </summary>
		public static HElement tt (ChainFunc<HAttributes.tt> attributes, params object[] children) { return new HElement ("tt", attributes (null), children); }        

		/// <summary>
        /// Defines text that should be stylistically different from normal text.
        /// </summary>
        
		public static HElement u (params object[] children) { return new HElement ("u", null, children); }
        
		/// <summary>
        /// Defines text that should be stylistically different from normal text.
        /// </summary>
		public static HElement u (ChainFunc<HAttributes.u> attributes, params object[] children) { return new HElement ("u", attributes (null), children); }        

		/// <summary>
        /// Defines an unordered list.
        /// </summary>
        
		public static HElement ul (params object[] children) { return new HElement ("ul", null, children); }
        
		/// <summary>
        /// Defines an unordered list.
        /// </summary>
		public static HElement ul (ChainFunc<HAttributes.ul> attributes, params object[] children) { return new HElement ("ul", attributes (null), children); }        

		/// <summary>
        /// Defines a variable.
        /// </summary>
        
		public static HElement var (params object[] children) { return new HElement ("var", null, children); }
        
		/// <summary>
        /// Defines a variable.
        /// </summary>
		public static HElement var (ChainFunc<HAttributes.var> attributes, params object[] children) { return new HElement ("var", attributes (null), children); }        

		/// <summary>
        /// Defines a video or movie.
        /// </summary>
        
		public static HElement video (params object[] children) { return new HElement ("video", null, children); }
        
		/// <summary>
        /// Defines a video or movie.
        /// </summary>
		public static HElement video (ChainFunc<HAttributes.video> attributes, params object[] children) { return new HElement ("video", attributes (null), children); }        

		/// <summary>
        /// Defines a possible line-break.
        /// </summary>
        
		public static HElement wbr (params object[] children) { return new HElement ("wbr", null, children); }
        
		/// <summary>
        /// Defines a possible line-break.
        /// </summary>
		public static HElement wbr (ChainFunc<HAttributes.wbr> attributes, params object[] children) { return new HElement ("wbr", attributes (null), children); }        

        // Helpers

        public static HDoc Doc (params object[] children) {return new HDoc (null, children);}
        public static HDoc Doc (ChainFunc<HAttributes.html> attributes, params object[] children) {return new HDoc (attributes(null), children);}
        public static HNode Literal (string s) {return HExtensions.Literal (s);}
        public static string Url (Expression<Action> action) {return HExtensions.Url (action);}
        public static string Url<T> (Expression<Action<T>> action) {return HExtensions.Url (action);}     
		public static HElement A (string url, object content, ChainFunc<HAttributes.a> attributes = null) {return H.a (a => a.href(url).Join(attributes), content);}
        public static HElement A (Expression<Action> action, object content, ChainFunc<HAttributes.a> attributes = null) {return H.a (a => a.href (HExtensions.Url(action)).Join(attributes), content);}
    }

    public static class HAttributeExtensions
    { 
		/// <summary>
        /// Indicates that the hyperlink is to be used for downloading a resource.
        /// </summary>
        public static IChain<T> download<T> (this IChain<T> attributes, object value) where T : HAttribute, IdownloadAttribute,  new() { return attributes.Custom ("download", value); }        

		/// <summary>
        /// The URL of a linked resource.
        /// </summary>
        public static IChain<T> href<T> (this IChain<T> attributes, object value) where T : HAttribute, IhrefAttribute,  new() { return attributes.Custom ("href", value); }        

		/// <summary>
        /// Specifies the language of the linked resource.
        /// </summary>
        public static IChain<T> hreflang<T> (this IChain<T> attributes, object value) where T : HAttribute, IhreflangAttribute,  new() { return attributes.Custom ("hreflang", value); }        

		/// <summary>
        /// Specifies a hint of the media for which the linked resource was designed.
        /// </summary>
        public static IChain<T> media<T> (this IChain<T> attributes, object value) where T : HAttribute, ImediaAttribute,  new() { return attributes.Custom ("media", value); }        

		/// <summary>
        /// 
        /// </summary>
        public static IChain<T> ping<T> (this IChain<T> attributes, object value) where T : HAttribute, IpingAttribute,  new() { return attributes.Custom ("ping", value); }        

		/// <summary>
        /// Specifies the relationship of the target object to the link object.
        /// </summary>
        public static IChain<T> rel<T> (this IChain<T> attributes, object value) where T : HAttribute, IrelAttribute,  new() { return attributes.Custom ("rel", value); }        

		/// <summary>
        /// 
        /// </summary>
        public static IChain<T> shape<T> (this IChain<T> attributes, object value) where T : HAttribute, IshapeAttribute,  new() { return attributes.Custom ("shape", value); }        

		/// <summary>
        /// 
        /// </summary>
        public static IChain<T> target<T> (this IChain<T> attributes, object value) where T : HAttribute, ItargetAttribute,  new() { return attributes.Custom ("target", value); }        

		/// <summary>
        /// Specifies the horizontal alignment of the element.
        /// </summary>
        public static IChain<T> align<T> (this IChain<T> attributes, object value) where T : HAttribute, IalignAttribute,  new() { return attributes.Custom ("align", value); }        

		/// <summary>
        /// Alternative text in case an image can't be displayed.
        /// </summary>
        public static IChain<T> alt<T> (this IChain<T> attributes, object value) where T : HAttribute, IaltAttribute,  new() { return attributes.Custom ("alt", value); }        

		/// <summary>
        /// Specifies the URL of the applet's class file to be loaded and executed.
        /// </summary>
        public static IChain<T> code<T> (this IChain<T> attributes, object value) where T : HAttribute, IcodeAttribute,  new() { return attributes.Custom ("code", value); }        

		/// <summary>
        /// This attribute gives the absolute or relative URL of the directory where applets' .class files referenced by the code attribute are stored.
        /// </summary>
        public static IChain<T> codebase<T> (this IChain<T> attributes, object value) where T : HAttribute, IcodebaseAttribute,  new() { return attributes.Custom ("codebase", value); }        

		/// <summary>
        /// A set of values specifying the coordinates of the hot-spot region.
        /// </summary>
        public static IChain<T> coords<T> (this IChain<T> attributes, object value) where T : HAttribute, IcoordsAttribute,  new() { return attributes.Custom ("coords", value); }        

		/// <summary>
        /// The audio or video should play as soon as possible.
        /// </summary>
        public static IChain<T> autoplay<T> (this IChain<T> attributes, object value) where T : HAttribute, IautoplayAttribute,  new() { return attributes.Custom ("autoplay", value); }        

		/// <summary>
        /// Contains the time range of already buffered media.
        /// </summary>
        public static IChain<T> buffered<T> (this IChain<T> attributes, object value) where T : HAttribute, IbufferedAttribute,  new() { return attributes.Custom ("buffered", value); }        

		/// <summary>
        /// Indicates whether the browser should show playback controls to the user.
        /// </summary>
        public static IChain<T> controls<T> (this IChain<T> attributes, object value) where T : HAttribute, IcontrolsAttribute,  new() { return attributes.Custom ("controls", value); }        

		/// <summary>
        /// Indicates whether the media should start playing from the start when it's finished.
        /// </summary>
        public static IChain<T> loop<T> (this IChain<T> attributes, object value) where T : HAttribute, IloopAttribute,  new() { return attributes.Custom ("loop", value); }        

		/// <summary>
        /// Indicates whether the whole resource, parts of it or nothing should be preloaded.
        /// </summary>
        public static IChain<T> preload<T> (this IChain<T> attributes, object value) where T : HAttribute, IpreloadAttribute,  new() { return attributes.Custom ("preload", value); }        

		/// <summary>
        /// The URL of the embeddable content.
        /// </summary>
        public static IChain<T> src<T> (this IChain<T> attributes, object value) where T : HAttribute, IsrcAttribute,  new() { return attributes.Custom ("src", value); }        

		/// <summary>
        /// Contains a URI which points to the source of the quote or change.
        /// </summary>
        public static IChain<T> cite<T> (this IChain<T> attributes, object value) where T : HAttribute, IciteAttribute,  new() { return attributes.Custom ("cite", value); }        

		/// <summary>
        /// Note: In some instances, such as <div>, this is a legacy attribute, in which case the CSS height property should be used instead. In other cases, such as <canvas>, the height must be specified with this attribute.
        /// </summary>
        public static IChain<T> height<T> (this IChain<T> attributes, object value) where T : HAttribute, IheightAttribute,  new() { return attributes.Custom ("height", value); }        

		/// <summary>
        /// Note: In some instances, such as <div>, this is a legacy attribute, in which case the CSS width property should be used instead. In other cases, such as <canvas>, the width must be specified with this attribute.
        /// </summary>
        public static IChain<T> width<T> (this IChain<T> attributes, object value) where T : HAttribute, IwidthAttribute,  new() { return attributes.Custom ("width", value); }        

		/// <summary>
        /// 
        /// </summary>
        public static IChain<T> span<T> (this IChain<T> attributes, object value) where T : HAttribute, IspanAttribute,  new() { return attributes.Custom ("span", value); }        

		/// <summary>
        /// Indicates whether the element should be checked on page load.
        /// </summary>
        public static IChain<T> @checked<T> (this IChain<T> attributes, object value) where T : HAttribute, IcheckedAttribute,  new() { return attributes.Custom ("checked", value); }        

		/// <summary>
        /// Indicates whether the user can interact with the element.
        /// </summary>
        public static IChain<T> disabled<T> (this IChain<T> attributes, object value) where T : HAttribute, IdisabledAttribute,  new() { return attributes.Custom ("disabled", value); }        

		/// <summary>
        /// Specifies a picture which represents the command.
        /// </summary>
        public static IChain<T> icon<T> (this IChain<T> attributes, object value) where T : HAttribute, IiconAttribute,  new() { return attributes.Custom ("icon", value); }        

		/// <summary>
        /// 
        /// </summary>
        public static IChain<T> radiogroup<T> (this IChain<T> attributes, object value) where T : HAttribute, IradiogroupAttribute,  new() { return attributes.Custom ("radiogroup", value); }        

		/// <summary>
        /// Defines the type of the element.
        /// </summary>
        public static IChain<T> type<T> (this IChain<T> attributes, object value) where T : HAttribute, ItypeAttribute,  new() { return attributes.Custom ("type", value); }        

		/// <summary>
        /// Indicates the date and time associated with the element.
        /// </summary>
        public static IChain<T> datetime<T> (this IChain<T> attributes, object value) where T : HAttribute, IdatetimeAttribute,  new() { return attributes.Custom ("datetime", value); }        

		/// <summary>
        /// Indicates whether the details will be shown on page load.
        /// </summary>
        public static IChain<T> open<T> (this IChain<T> attributes, object value) where T : HAttribute, IopenAttribute,  new() { return attributes.Custom ("open", value); }        

		/// <summary>
        /// Indicates the form that is the owner of the element.
        /// </summary>
        public static IChain<T> form<T> (this IChain<T> attributes, object value) where T : HAttribute, IformAttribute,  new() { return attributes.Custom ("form", value); }        

		/// <summary>
        /// Name of the element. For example used by the server to identify the fields in form submits.
        /// </summary>
        public static IChain<T> name<T> (this IChain<T> attributes, object value) where T : HAttribute, InameAttribute,  new() { return attributes.Custom ("name", value); }        

		/// <summary>
        /// List of types the server accepts, typically a file type.
        /// </summary>
        public static IChain<T> accept<T> (this IChain<T> attributes, object value) where T : HAttribute, IacceptAttribute,  new() { return attributes.Custom ("accept", value); }        

		/// <summary>
        /// List of supported charsets.
        /// </summary>
        public static IChain<T> accept_charset<T> (this IChain<T> attributes, object value) where T : HAttribute, Iaccept_charsetAttribute,  new() { return attributes.Custom ("accept-charset", value); }        

		/// <summary>
        /// The URI of a program that processes the information submitted via the form.
        /// </summary>
        public static IChain<T> action<T> (this IChain<T> attributes, object value) where T : HAttribute, IactionAttribute,  new() { return attributes.Custom ("action", value); }        

		/// <summary>
        /// Indicates whether controls in this form can by default have their values automatically completed by the browser.
        /// </summary>
        public static IChain<T> autocomplete<T> (this IChain<T> attributes, object value) where T : HAttribute, IautocompleteAttribute,  new() { return attributes.Custom ("autocomplete", value); }        

		/// <summary>
        /// Defines the content type of the form date when the method is POST.
        /// </summary>
        public static IChain<T> enctype<T> (this IChain<T> attributes, object value) where T : HAttribute, IenctypeAttribute,  new() { return attributes.Custom ("enctype", value); }        

		/// <summary>
        /// Defines which HTTP method to use when submitting the form. Can be GET (default) or POST.
        /// </summary>
        public static IChain<T> method<T> (this IChain<T> attributes, object value) where T : HAttribute, ImethodAttribute,  new() { return attributes.Custom ("method", value); }        

		/// <summary>
        /// This attribute indicates that the form shouldn't be validated when submitted.
        /// </summary>
        public static IChain<T> novalidate<T> (this IChain<T> attributes, object value) where T : HAttribute, InovalidateAttribute,  new() { return attributes.Custom ("novalidate", value); }        

		/// <summary>
        /// Specifies the URL of the document's cache manifest.
        /// </summary>
        public static IChain<T> manifest<T> (this IChain<T> attributes, object value) where T : HAttribute, ImanifestAttribute,  new() { return attributes.Custom ("manifest", value); }        

		/// <summary>
        /// 
        /// </summary>
        public static IChain<T> sandbox<T> (this IChain<T> attributes, object value) where T : HAttribute, IsandboxAttribute,  new() { return attributes.Custom ("sandbox", value); }        

		/// <summary>
        /// 
        /// </summary>
        public static IChain<T> seamless<T> (this IChain<T> attributes, object value) where T : HAttribute, IseamlessAttribute,  new() { return attributes.Custom ("seamless", value); }        

		/// <summary>
        /// 
        /// </summary>
        public static IChain<T> srcdoc<T> (this IChain<T> attributes, object value) where T : HAttribute, IsrcdocAttribute,  new() { return attributes.Custom ("srcdoc", value); }        

		/// <summary>
        /// Indicatesthat the image is part of a server-side image map.
        /// </summary>
        public static IChain<T> ismap<T> (this IChain<T> attributes, object value) where T : HAttribute, IismapAttribute,  new() { return attributes.Custom ("ismap", value); }        

		/// <summary>
        /// 
        /// </summary>
        public static IChain<T> usemap<T> (this IChain<T> attributes, object value) where T : HAttribute, IusemapAttribute,  new() { return attributes.Custom ("usemap", value); }        

		/// <summary>
        /// The element should be automatically focused after the page loaded.
        /// </summary>
        public static IChain<T> autofocus<T> (this IChain<T> attributes, object value) where T : HAttribute, IautofocusAttribute,  new() { return attributes.Custom ("autofocus", value); }        

		/// <summary>
        /// 
        /// </summary>
        public static IChain<T> dirname<T> (this IChain<T> attributes, object value) where T : HAttribute, IdirnameAttribute,  new() { return attributes.Custom ("dirname", value); }        

		/// <summary>
        /// Identifies a list of pre-defined options to suggest to the user.
        /// </summary>
        public static IChain<T> list<T> (this IChain<T> attributes, object value) where T : HAttribute, IlistAttribute,  new() { return attributes.Custom ("list", value); }        

		/// <summary>
        /// Indicates the maximum value allowed.
        /// </summary>
        public static IChain<T> max<T> (this IChain<T> attributes, object value) where T : HAttribute, ImaxAttribute,  new() { return attributes.Custom ("max", value); }        

		/// <summary>
        /// Defines the maximum number of characters allowed in the element.
        /// </summary>
        public static IChain<T> maxlength<T> (this IChain<T> attributes, object value) where T : HAttribute, ImaxlengthAttribute,  new() { return attributes.Custom ("maxlength", value); }        

		/// <summary>
        /// Indicates the minimum value allowed.
        /// </summary>
        public static IChain<T> min<T> (this IChain<T> attributes, object value) where T : HAttribute, IminAttribute,  new() { return attributes.Custom ("min", value); }        

		/// <summary>
        /// Indicates whether multiple values can be entered in an input of the type email or file.
        /// </summary>
        public static IChain<T> multiple<T> (this IChain<T> attributes, object value) where T : HAttribute, ImultipleAttribute,  new() { return attributes.Custom ("multiple", value); }        

		/// <summary>
        /// Defines a regular expression which the element's value will be validated against.
        /// </summary>
        public static IChain<T> pattern<T> (this IChain<T> attributes, object value) where T : HAttribute, IpatternAttribute,  new() { return attributes.Custom ("pattern", value); }        

		/// <summary>
        /// Provides a hint to the user of what can be entered in the field.
        /// </summary>
        public static IChain<T> placeholder<T> (this IChain<T> attributes, object value) where T : HAttribute, IplaceholderAttribute,  new() { return attributes.Custom ("placeholder", value); }        

		/// <summary>
        /// Indicates whether the element can be edited.
        /// </summary>
        public static IChain<T> @readonly<T> (this IChain<T> attributes, object value) where T : HAttribute, IreadonlyAttribute,  new() { return attributes.Custom ("readonly", value); }        

		/// <summary>
        /// Indicates whether this element is required to fill out or not.
        /// </summary>
        public static IChain<T> required<T> (this IChain<T> attributes, object value) where T : HAttribute, IrequiredAttribute,  new() { return attributes.Custom ("required", value); }        

		/// <summary>
        /// Defines the width of the element (in pixels). If the element's type attribute is text or password then it's the number of characters.
        /// </summary>
        public static IChain<T> size<T> (this IChain<T> attributes, object value) where T : HAttribute, IsizeAttribute,  new() { return attributes.Custom ("size", value); }        

		/// <summary>
        /// 
        /// </summary>
        public static IChain<T> step<T> (this IChain<T> attributes, object value) where T : HAttribute, IstepAttribute,  new() { return attributes.Custom ("step", value); }        

		/// <summary>
        /// Defines a default value which will be displayed in the element on page load.
        /// </summary>
        public static IChain<T> value<T> (this IChain<T> attributes, object value) where T : HAttribute, IvalueAttribute,  new() { return attributes.Custom ("value", value); }        

		/// <summary>
        /// A challenge string that is submitted along with the public key.
        /// </summary>
        public static IChain<T> challenge<T> (this IChain<T> attributes, object value) where T : HAttribute, IchallengeAttribute,  new() { return attributes.Custom ("challenge", value); }        

		/// <summary>
        /// Specifies the type of key generated.
        /// </summary>
        public static IChain<T> keytype<T> (this IChain<T> attributes, object value) where T : HAttribute, IkeytypeAttribute,  new() { return attributes.Custom ("keytype", value); }        

		/// <summary>
        /// Describes elements which belongs to this one.
        /// </summary>
        public static IChain<T> @for<T> (this IChain<T> attributes, object value) where T : HAttribute, IforAttribute,  new() { return attributes.Custom ("for", value); }        

		/// <summary>
        /// 
        /// </summary>
        public static IChain<T> sizes<T> (this IChain<T> attributes, object value) where T : HAttribute, IsizesAttribute,  new() { return attributes.Custom ("sizes", value); }        

		/// <summary>
        /// Declares the character encoding of the page or script.
        /// </summary>
        public static IChain<T> charset<T> (this IChain<T> attributes, object value) where T : HAttribute, IcharsetAttribute,  new() { return attributes.Custom ("charset", value); }        

		/// <summary>
        /// A value associated with http-equiv or name depending on the context.
        /// </summary>
        public static IChain<T> content<T> (this IChain<T> attributes, object value) where T : HAttribute, IcontentAttribute,  new() { return attributes.Custom ("content", value); }        

		/// <summary>
        /// 
        /// </summary>
        public static IChain<T> http_equiv<T> (this IChain<T> attributes, object value) where T : HAttribute, Ihttp_equivAttribute,  new() { return attributes.Custom ("http-equiv", value); }        

		/// <summary>
        /// Indicates the lower bound of the upper range.
        /// </summary>
        public static IChain<T> high<T> (this IChain<T> attributes, object value) where T : HAttribute, IhighAttribute,  new() { return attributes.Custom ("high", value); }        

		/// <summary>
        /// Indicates the upper bound of the lower range.
        /// </summary>
        public static IChain<T> low<T> (this IChain<T> attributes, object value) where T : HAttribute, IlowAttribute,  new() { return attributes.Custom ("low", value); }        

		/// <summary>
        /// Indicates the optimal numeric value.
        /// </summary>
        public static IChain<T> optimum<T> (this IChain<T> attributes, object value) where T : HAttribute, IoptimumAttribute,  new() { return attributes.Custom ("optimum", value); }        

		/// <summary>
        /// Specifies the URL of the resource.
        /// </summary>
        public static IChain<T> data<T> (this IChain<T> attributes, object value) where T : HAttribute, IdataAttribute,  new() { return attributes.Custom ("data", value); }        

		/// <summary>
        /// Indicates whether the list should be displayed in a descending order instead of a ascending.
        /// </summary>
        public static IChain<T> reversed<T> (this IChain<T> attributes, object value) where T : HAttribute, IreversedAttribute,  new() { return attributes.Custom ("reversed", value); }        

		/// <summary>
        /// Defines the first number if other than 1.
        /// </summary>
        public static IChain<T> start<T> (this IChain<T> attributes, object value) where T : HAttribute, IstartAttribute,  new() { return attributes.Custom ("start", value); }        

		/// <summary>
        /// Defines a value which will be selected on page load.
        /// </summary>
        public static IChain<T> selected<T> (this IChain<T> attributes, object value) where T : HAttribute, IselectedAttribute,  new() { return attributes.Custom ("selected", value); }        

		/// <summary>
        /// Indicates that the script should be executed asynchronously.
        /// </summary>
        public static IChain<T> async<T> (this IChain<T> attributes, object value) where T : HAttribute, IasyncAttribute,  new() { return attributes.Custom ("async", value); }        

		/// <summary>
        /// Indicates that the script should be executed after the page has been parsed.
        /// </summary>
        public static IChain<T> defer<T> (this IChain<T> attributes, object value) where T : HAttribute, IdeferAttribute,  new() { return attributes.Custom ("defer", value); }        

		/// <summary>
        /// Defines the script language used in the element.
        /// </summary>
        public static IChain<T> language<T> (this IChain<T> attributes, object value) where T : HAttribute, IlanguageAttribute,  new() { return attributes.Custom ("language", value); }        

		/// <summary>
        /// 
        /// </summary>
        public static IChain<T> scoped<T> (this IChain<T> attributes, object value) where T : HAttribute, IscopedAttribute,  new() { return attributes.Custom ("scoped", value); }        

		/// <summary>
        /// 
        /// </summary>
        public static IChain<T> summary<T> (this IChain<T> attributes, object value) where T : HAttribute, IsummaryAttribute,  new() { return attributes.Custom ("summary", value); }        

		/// <summary>
        /// The colspan attribute defines the number of columns a cell should span.
        /// </summary>
        public static IChain<T> colspan<T> (this IChain<T> attributes, object value) where T : HAttribute, IcolspanAttribute,  new() { return attributes.Custom ("colspan", value); }        

		/// <summary>
        /// IDs of the <th> elements which applies to this element.
        /// </summary>
        public static IChain<T> headers<T> (this IChain<T> attributes, object value) where T : HAttribute, IheadersAttribute,  new() { return attributes.Custom ("headers", value); }        

		/// <summary>
        /// Defines the number of rows a table cell should span over.
        /// </summary>
        public static IChain<T> rowspan<T> (this IChain<T> attributes, object value) where T : HAttribute, IrowspanAttribute,  new() { return attributes.Custom ("rowspan", value); }        

		/// <summary>
        /// Defines the number of columns in a textarea.
        /// </summary>
        public static IChain<T> cols<T> (this IChain<T> attributes, object value) where T : HAttribute, IcolsAttribute,  new() { return attributes.Custom ("cols", value); }        

		/// <summary>
        /// Defines the number of rows in a textarea.
        /// </summary>
        public static IChain<T> rows<T> (this IChain<T> attributes, object value) where T : HAttribute, IrowsAttribute,  new() { return attributes.Custom ("rows", value); }        

		/// <summary>
        /// Indicates whether the text should be wrapped.
        /// </summary>
        public static IChain<T> wrap<T> (this IChain<T> attributes, object value) where T : HAttribute, IwrapAttribute,  new() { return attributes.Custom ("wrap", value); }        

		/// <summary>
        /// 
        /// </summary>
        public static IChain<T> scope<T> (this IChain<T> attributes, object value) where T : HAttribute, IscopeAttribute,  new() { return attributes.Custom ("scope", value); }        

		/// <summary>
        /// Indicates whether this date and time is the date of the nearest <article> ancestor element.
        /// </summary>
        public static IChain<T> pubdate<T> (this IChain<T> attributes, object value) where T : HAttribute, IpubdateAttribute,  new() { return attributes.Custom ("pubdate", value); }        

		/// <summary>
        /// Indicates that the track should be enabled unless the user's preferences indicate something different.
        /// </summary>
        public static IChain<T> @default<T> (this IChain<T> attributes, object value) where T : HAttribute, IdefaultAttribute,  new() { return attributes.Custom ("default", value); }        

		/// <summary>
        /// Specifies the kind of text track.
        /// </summary>
        public static IChain<T> kind<T> (this IChain<T> attributes, object value) where T : HAttribute, IkindAttribute,  new() { return attributes.Custom ("kind", value); }        

		/// <summary>
        /// Specifies a user-readable title of the text track.
        /// </summary>
        public static IChain<T> label<T> (this IChain<T> attributes, object value) where T : HAttribute, IlabelAttribute,  new() { return attributes.Custom ("label", value); }        

		/// <summary>
        /// 
        /// </summary>
        public static IChain<T> srclang<T> (this IChain<T> attributes, object value) where T : HAttribute, IsrclangAttribute,  new() { return attributes.Custom ("srclang", value); }        

		/// <summary>
        /// A URL indicating a poster frame to show until the user plays or seeks.
        /// </summary>
        public static IChain<T> poster<T> (this IChain<T> attributes, object value) where T : HAttribute, IposterAttribute,  new() { return attributes.Custom ("poster", value); }        

		/// <summary>
        /// Defines a keyboard shortcut to activate or add focus to the element.
        /// </summary>
        public static IChain<T> accesskey<T> (this IChain<T> attributes, object value) where T : HAttribute,  new() { return attributes.Custom ("accesskey", value); }        

		/// <summary>
        /// Often used with CSS to style elements with common properties.
        /// </summary>
        public static IChain<T> css<T> (this IChain<T> attributes, object value) where T : HAttribute,  new() { return attributes.Custom ("class", value); }        

		/// <summary>
        /// Indicates whether the element's content is editable.
        /// </summary>
        public static IChain<T> contenteditable<T> (this IChain<T> attributes, object value) where T : HAttribute,  new() { return attributes.Custom ("contenteditable", value); }        

		/// <summary>
        /// Defines the ID of a <menu> element which will serve as the element's context menu.
        /// </summary>
        public static IChain<T> contextmenu<T> (this IChain<T> attributes, object value) where T : HAttribute,  new() { return attributes.Custom ("contextmenu", value); }        

		/// <summary>
        /// lets you attach custom attribute to html elements.
        /// </summary>
        public static IChain<T> data_custom<T> (this IChain<T> attributes, object value) where T : HAttribute,  new() { return attributes.Custom ("data-custom", value); }        

		/// <summary>
        /// Defines the text direction. Allowed values are ltr (Left-To-Right) or rtl (Right-To-Left)
        /// </summary>
        public static IChain<T> dir<T> (this IChain<T> attributes, object value) where T : HAttribute,  new() { return attributes.Custom ("dir", value); }        

		/// <summary>
        /// Defines whether the element can be dragged.
        /// </summary>
        public static IChain<T> draggable<T> (this IChain<T> attributes, object value) where T : HAttribute,  new() { return attributes.Custom ("draggable", value); }        

		/// <summary>
        /// Indicates that the element accept the dropping of content on it.
        /// </summary>
        public static IChain<T> dropzone<T> (this IChain<T> attributes, object value) where T : HAttribute,  new() { return attributes.Custom ("dropzone", value); }        

		/// <summary>
        /// Indicates the relevance of an element.
        /// </summary>
        public static IChain<T> hidden<T> (this IChain<T> attributes, object value) where T : HAttribute,  new() { return attributes.Custom ("hidden", value); }        

		/// <summary>
        /// Often used with CSS to style a specific element. The value of this attribute must be unique.
        /// </summary>
        public static IChain<T> id<T> (this IChain<T> attributes, object value) where T : HAttribute,  new() { return attributes.Custom ("id", value); }        

		/// <summary>
        /// 
        /// </summary>
        public static IChain<T> itemprop<T> (this IChain<T> attributes, object value) where T : HAttribute,  new() { return attributes.Custom ("itemprop", value); }        

		/// <summary>
        /// Defines the language used in the element.
        /// </summary>
        public static IChain<T> lang<T> (this IChain<T> attributes, object value) where T : HAttribute,  new() { return attributes.Custom ("lang", value); }        

		/// <summary>
        /// Indicates whether spell checking is allowed for the element.
        /// </summary>
        public static IChain<T> spellcheck<T> (this IChain<T> attributes, object value) where T : HAttribute,  new() { return attributes.Custom ("spellcheck", value); }        

		/// <summary>
        /// Defines CSS styles which will override styles previously set.
        /// </summary>
        public static IChain<T> style<T> (this IChain<T> attributes, object value) where T : HAttribute,  new() { return attributes.Custom ("style", value); }        

		/// <summary>
        /// Overrides the browser's default tab order and follows the one specified instead.
        /// </summary>
        public static IChain<T> tabindex<T> (this IChain<T> attributes, object value) where T : HAttribute,  new() { return attributes.Custom ("tabindex", value); }        

		/// <summary>
        /// Text to be displayed in a tooltip when hovering over the element.
        /// </summary>
        public static IChain<T> title<T> (this IChain<T> attributes, object value) where T : HAttribute,  new() { return attributes.Custom ("title", value); }        

	
    }

	
    public static class HAttributes
    {
        public class a : HAttribute, IdownloadAttribute, IhrefAttribute, IhreflangAttribute, ImediaAttribute, IpingAttribute, IrelAttribute, IshapeAttribute, ItargetAttribute
        {
            public a () { }
            public a (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new a (name, value); }
        }

        public class abbr : HAttribute
        {
            public abbr () { }
            public abbr (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new abbr (name, value); }
        }

        public class acronym : HAttribute
        {
            public acronym () { }
            public acronym (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new acronym (name, value); }
        }

        public class address : HAttribute
        {
            public address () { }
            public address (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new address (name, value); }
        }

        public class applet : HAttribute, IalignAttribute, IaltAttribute, IcodeAttribute, IcodebaseAttribute
        {
            public applet () { }
            public applet (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new applet (name, value); }
        }

        public class area : HAttribute, IaltAttribute, IcoordsAttribute, IdownloadAttribute, IhrefAttribute, IhreflangAttribute, ImediaAttribute, IpingAttribute, IrelAttribute, IshapeAttribute, ItargetAttribute
        {
            public area () { }
            public area (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new area (name, value); }
        }

        public class article : HAttribute
        {
            public article () { }
            public article (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new article (name, value); }
        }

        public class aside : HAttribute
        {
            public aside () { }
            public aside (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new aside (name, value); }
        }

        public class audio : HAttribute, IautoplayAttribute, IbufferedAttribute, IcontrolsAttribute, IloopAttribute, IpreloadAttribute, IsrcAttribute
        {
            public audio () { }
            public audio (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new audio (name, value); }
        }

        public class b : HAttribute
        {
            public b () { }
            public b (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new b (name, value); }
        }

        public class @base : HAttribute, IhrefAttribute, ItargetAttribute
        {
            public @base () { }
            public @base (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new @base (name, value); }
        }

        public class basefont : HAttribute
        {
            public basefont () { }
            public basefont (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new basefont (name, value); }
        }

        public class bdi : HAttribute
        {
            public bdi () { }
            public bdi (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new bdi (name, value); }
        }

        public class bdo : HAttribute
        {
            public bdo () { }
            public bdo (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new bdo (name, value); }
        }

        public class big : HAttribute
        {
            public big () { }
            public big (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new big (name, value); }
        }

        public class blockquote : HAttribute, IciteAttribute
        {
            public blockquote () { }
            public blockquote (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new blockquote (name, value); }
        }

        public class body : HAttribute
        {
            public body () { }
            public body (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new body (name, value); }
        }

        public class br : HAttribute
        {
            public br () { }
            public br (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new br (name, value); }
        }

        public class canvas : HAttribute, IheightAttribute, IwidthAttribute
        {
            public canvas () { }
            public canvas (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new canvas (name, value); }
        }

        public class caption : HAttribute, IalignAttribute
        {
            public caption () { }
            public caption (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new caption (name, value); }
        }

        public class center : HAttribute
        {
            public center () { }
            public center (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new center (name, value); }
        }

        public class cite : HAttribute
        {
            public cite () { }
            public cite (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new cite (name, value); }
        }

        public class code : HAttribute
        {
            public code () { }
            public code (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new code (name, value); }
        }

        public class col : HAttribute, IalignAttribute, IspanAttribute
        {
            public col () { }
            public col (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new col (name, value); }
        }

        public class colgroup : HAttribute, IalignAttribute, IspanAttribute
        {
            public colgroup () { }
            public colgroup (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new colgroup (name, value); }
        }

        public class command : HAttribute, IcheckedAttribute, IdisabledAttribute, IiconAttribute, IradiogroupAttribute, ItypeAttribute
        {
            public command () { }
            public command (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new command (name, value); }
        }

        public class datalist : HAttribute
        {
            public datalist () { }
            public datalist (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new datalist (name, value); }
        }

        public class dd : HAttribute
        {
            public dd () { }
            public dd (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new dd (name, value); }
        }

        public class del : HAttribute, IciteAttribute, IdatetimeAttribute
        {
            public del () { }
            public del (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new del (name, value); }
        }

        public class details : HAttribute, IopenAttribute
        {
            public details () { }
            public details (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new details (name, value); }
        }

        public class dfn : HAttribute
        {
            public dfn () { }
            public dfn (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new dfn (name, value); }
        }

        public class dialog : HAttribute
        {
            public dialog () { }
            public dialog (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new dialog (name, value); }
        }

        public class dir : HAttribute
        {
            public dir () { }
            public dir (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new dir (name, value); }
        }

        public class div : HAttribute
        {
            public div () { }
            public div (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new div (name, value); }
        }

        public class dl : HAttribute
        {
            public dl () { }
            public dl (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new dl (name, value); }
        }

        public class dt : HAttribute
        {
            public dt () { }
            public dt (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new dt (name, value); }
        }

        public class em : HAttribute
        {
            public em () { }
            public em (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new em (name, value); }
        }

        public class embed : HAttribute, IheightAttribute, IsrcAttribute, ItypeAttribute, IwidthAttribute
        {
            public embed () { }
            public embed (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new embed (name, value); }
        }

        public class fieldset : HAttribute, IdisabledAttribute, IformAttribute, InameAttribute
        {
            public fieldset () { }
            public fieldset (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new fieldset (name, value); }
        }

        public class figcaption : HAttribute
        {
            public figcaption () { }
            public figcaption (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new figcaption (name, value); }
        }

        public class figure : HAttribute
        {
            public figure () { }
            public figure (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new figure (name, value); }
        }

        public class font : HAttribute
        {
            public font () { }
            public font (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new font (name, value); }
        }

        public class footer : HAttribute
        {
            public footer () { }
            public footer (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new footer (name, value); }
        }

        public class form : HAttribute, IacceptAttribute, Iaccept_charsetAttribute, IactionAttribute, IautocompleteAttribute, IenctypeAttribute, ImethodAttribute, InameAttribute, InovalidateAttribute, ItargetAttribute
        {
            public form () { }
            public form (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new form (name, value); }
        }

        public class frame : HAttribute
        {
            public frame () { }
            public frame (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new frame (name, value); }
        }

        public class frameset : HAttribute
        {
            public frameset () { }
            public frameset (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new frameset (name, value); }
        }

        public class h1 : HAttribute
        {
            public h1 () { }
            public h1 (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new h1 (name, value); }
        }

        public class h2 : HAttribute
        {
            public h2 () { }
            public h2 (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new h2 (name, value); }
        }

        public class h3 : HAttribute
        {
            public h3 () { }
            public h3 (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new h3 (name, value); }
        }

        public class h4 : HAttribute
        {
            public h4 () { }
            public h4 (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new h4 (name, value); }
        }

        public class h5 : HAttribute
        {
            public h5 () { }
            public h5 (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new h5 (name, value); }
        }

        public class h6 : HAttribute
        {
            public h6 () { }
            public h6 (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new h6 (name, value); }
        }

        public class head : HAttribute
        {
            public head () { }
            public head (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new head (name, value); }
        }

        public class header : HAttribute
        {
            public header () { }
            public header (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new header (name, value); }
        }

        public class hgroup : HAttribute
        {
            public hgroup () { }
            public hgroup (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new hgroup (name, value); }
        }

        public class hr : HAttribute, IalignAttribute
        {
            public hr () { }
            public hr (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new hr (name, value); }
        }

        public class html : HAttribute, ImanifestAttribute
        {
            public html () { }
            public html (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new html (name, value); }
        }

        public class i : HAttribute
        {
            public i () { }
            public i (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new i (name, value); }
        }

        public class iframe : HAttribute, IalignAttribute, IheightAttribute, InameAttribute, IsandboxAttribute, IseamlessAttribute, IsrcAttribute, IsrcdocAttribute, IwidthAttribute
        {
            public iframe () { }
            public iframe (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new iframe (name, value); }
        }

        public class img : HAttribute, IalignAttribute, IaltAttribute, IheightAttribute, IismapAttribute, IsrcAttribute, IusemapAttribute, IwidthAttribute
        {
            public img () { }
            public img (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new img (name, value); }
        }

        public class input : HAttribute, IacceptAttribute, IaltAttribute, IautocompleteAttribute, IautofocusAttribute, IcheckedAttribute, IdirnameAttribute, IdisabledAttribute, IformAttribute, IheightAttribute, IlistAttribute, ImaxAttribute, ImaxlengthAttribute, IminAttribute, ImultipleAttribute, InameAttribute, IpatternAttribute, IplaceholderAttribute, IreadonlyAttribute, IrequiredAttribute, IsizeAttribute, IsrcAttribute, IstepAttribute, ItypeAttribute, IusemapAttribute, IvalueAttribute, IwidthAttribute
        {
            public input () { }
            public input (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new input (name, value); }
        }

        public class ins : HAttribute, IciteAttribute, IdatetimeAttribute
        {
            public ins () { }
            public ins (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new ins (name, value); }
        }

        public class kbd : HAttribute
        {
            public kbd () { }
            public kbd (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new kbd (name, value); }
        }

        public class keygen : HAttribute, IautofocusAttribute, IchallengeAttribute, IdisabledAttribute, IformAttribute, IkeytypeAttribute, InameAttribute
        {
            public keygen () { }
            public keygen (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new keygen (name, value); }
        }

        public class label : HAttribute, IforAttribute, IformAttribute
        {
            public label () { }
            public label (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new label (name, value); }
        }

        public class legend : HAttribute
        {
            public legend () { }
            public legend (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new legend (name, value); }
        }

        public class li : HAttribute, IvalueAttribute
        {
            public li () { }
            public li (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new li (name, value); }
        }

        public class link : HAttribute, IhrefAttribute, IhreflangAttribute, ImediaAttribute, IrelAttribute, IsizesAttribute, ItypeAttribute
        {
            public link () { }
            public link (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new link (name, value); }
        }

        public class map : HAttribute, InameAttribute
        {
            public map () { }
            public map (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new map (name, value); }
        }

        public class mark : HAttribute
        {
            public mark () { }
            public mark (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new mark (name, value); }
        }

        public class menu : HAttribute, ItypeAttribute
        {
            public menu () { }
            public menu (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new menu (name, value); }
        }

        public class meta : HAttribute, IcharsetAttribute, IcontentAttribute, Ihttp_equivAttribute, InameAttribute
        {
            public meta () { }
            public meta (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new meta (name, value); }
        }

        public class meter : HAttribute, IformAttribute, IhighAttribute, IlowAttribute, ImaxAttribute, IminAttribute, IoptimumAttribute, IvalueAttribute
        {
            public meter () { }
            public meter (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new meter (name, value); }
        }

        public class nav : HAttribute
        {
            public nav () { }
            public nav (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new nav (name, value); }
        }

        public class noframes : HAttribute
        {
            public noframes () { }
            public noframes (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new noframes (name, value); }
        }

        public class noscript : HAttribute
        {
            public noscript () { }
            public noscript (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new noscript (name, value); }
        }

        public class @object : HAttribute, IdataAttribute, IformAttribute, IheightAttribute, InameAttribute, ItypeAttribute, IusemapAttribute, IwidthAttribute
        {
            public @object () { }
            public @object (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new @object (name, value); }
        }

        public class ol : HAttribute, IreversedAttribute, IstartAttribute
        {
            public ol () { }
            public ol (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new ol (name, value); }
        }

        public class optgroup : HAttribute, IdisabledAttribute
        {
            public optgroup () { }
            public optgroup (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new optgroup (name, value); }
        }

        public class option : HAttribute, IdisabledAttribute, IselectedAttribute, IvalueAttribute
        {
            public option () { }
            public option (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new option (name, value); }
        }

        public class output : HAttribute, IforAttribute, IformAttribute, InameAttribute
        {
            public output () { }
            public output (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new output (name, value); }
        }

        public class p : HAttribute
        {
            public p () { }
            public p (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new p (name, value); }
        }

        public class param : HAttribute, InameAttribute, IvalueAttribute
        {
            public param () { }
            public param (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new param (name, value); }
        }

        public class pre : HAttribute
        {
            public pre () { }
            public pre (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new pre (name, value); }
        }

        public class progress : HAttribute, IformAttribute, ImaxAttribute, IvalueAttribute
        {
            public progress () { }
            public progress (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new progress (name, value); }
        }

        public class q : HAttribute, IciteAttribute
        {
            public q () { }
            public q (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new q (name, value); }
        }

        public class rp : HAttribute
        {
            public rp () { }
            public rp (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new rp (name, value); }
        }

        public class rt : HAttribute
        {
            public rt () { }
            public rt (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new rt (name, value); }
        }

        public class ruby : HAttribute
        {
            public ruby () { }
            public ruby (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new ruby (name, value); }
        }

        public class s : HAttribute
        {
            public s () { }
            public s (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new s (name, value); }
        }

        public class samp : HAttribute
        {
            public samp () { }
            public samp (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new samp (name, value); }
        }

        public class script : HAttribute, IasyncAttribute, IcharsetAttribute, IdeferAttribute, IlanguageAttribute, IsrcAttribute, ItypeAttribute
        {
            public script () { }
            public script (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new script (name, value); }
        }

        public class section : HAttribute
        {
            public section () { }
            public section (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new section (name, value); }
        }

        public class select : HAttribute, IautofocusAttribute, IdisabledAttribute, IformAttribute, ImultipleAttribute, InameAttribute, IrequiredAttribute, IsizeAttribute
        {
            public select () { }
            public select (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new select (name, value); }
        }

        public class small : HAttribute
        {
            public small () { }
            public small (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new small (name, value); }
        }

        public class source : HAttribute, ImediaAttribute, IsrcAttribute, ItypeAttribute
        {
            public source () { }
            public source (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new source (name, value); }
        }

        public class span : HAttribute
        {
            public span () { }
            public span (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new span (name, value); }
        }

        public class strike : HAttribute
        {
            public strike () { }
            public strike (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new strike (name, value); }
        }

        public class strong : HAttribute
        {
            public strong () { }
            public strong (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new strong (name, value); }
        }

        public class style : HAttribute, ImediaAttribute, IscopedAttribute, ItypeAttribute
        {
            public style () { }
            public style (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new style (name, value); }
        }

        public class sub : HAttribute
        {
            public sub () { }
            public sub (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new sub (name, value); }
        }

        public class summary : HAttribute
        {
            public summary () { }
            public summary (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new summary (name, value); }
        }

        public class sup : HAttribute
        {
            public sup () { }
            public sup (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new sup (name, value); }
        }

        public class table : HAttribute, IalignAttribute, IsummaryAttribute
        {
            public table () { }
            public table (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new table (name, value); }
        }

        public class tbody : HAttribute, IalignAttribute
        {
            public tbody () { }
            public tbody (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new tbody (name, value); }
        }

        public class td : HAttribute, IalignAttribute, IcolspanAttribute, IheadersAttribute, IrowspanAttribute
        {
            public td () { }
            public td (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new td (name, value); }
        }

        public class textarea : HAttribute, IautofocusAttribute, IcolsAttribute, IdirnameAttribute, IdisabledAttribute, IformAttribute, ImaxlengthAttribute, InameAttribute, IplaceholderAttribute, IreadonlyAttribute, IrequiredAttribute, IrowsAttribute, IwrapAttribute
        {
            public textarea () { }
            public textarea (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new textarea (name, value); }
        }

        public class tfoot : HAttribute, IalignAttribute
        {
            public tfoot () { }
            public tfoot (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new tfoot (name, value); }
        }

        public class th : HAttribute, IalignAttribute, IcolspanAttribute, IheadersAttribute, IrowspanAttribute, IscopeAttribute
        {
            public th () { }
            public th (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new th (name, value); }
        }

        public class thead : HAttribute, IalignAttribute
        {
            public thead () { }
            public thead (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new thead (name, value); }
        }

        public class time : HAttribute, IdatetimeAttribute, IpubdateAttribute
        {
            public time () { }
            public time (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new time (name, value); }
        }

        public class title : HAttribute
        {
            public title () { }
            public title (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new title (name, value); }
        }

        public class tr : HAttribute, IalignAttribute
        {
            public tr () { }
            public tr (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new tr (name, value); }
        }

        public class track : HAttribute, IdefaultAttribute, IkindAttribute, IlabelAttribute, IsrcAttribute, IsrclangAttribute
        {
            public track () { }
            public track (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new track (name, value); }
        }

        public class tt : HAttribute
        {
            public tt () { }
            public tt (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new tt (name, value); }
        }

        public class u : HAttribute
        {
            public u () { }
            public u (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new u (name, value); }
        }

        public class ul : HAttribute
        {
            public ul () { }
            public ul (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new ul (name, value); }
        }

        public class var : HAttribute
        {
            public var () { }
            public var (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new var (name, value); }
        }

        public class video : HAttribute, IautoplayAttribute, IbufferedAttribute, IcontrolsAttribute, IheightAttribute, IloopAttribute, IposterAttribute, IpreloadAttribute, IsrcAttribute, IwidthAttribute
        {
            public video () { }
            public video (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new video (name, value); }
        }

        public class wbr : HAttribute
        {
            public wbr () { }
            public wbr (string name, object value) : base (name, value) {}
            public override HAttribute Create (string name, object value) {return new wbr (name, value); }
        }


    }

    namespace Imp
    {

        public interface IdownloadAttribute {}
        public interface IhrefAttribute {}
        public interface IhreflangAttribute {}
        public interface ImediaAttribute {}
        public interface IpingAttribute {}
        public interface IrelAttribute {}
        public interface IshapeAttribute {}
        public interface ItargetAttribute {}
        public interface IalignAttribute {}
        public interface IaltAttribute {}
        public interface IcodeAttribute {}
        public interface IcodebaseAttribute {}
        public interface IcoordsAttribute {}
        public interface IautoplayAttribute {}
        public interface IbufferedAttribute {}
        public interface IcontrolsAttribute {}
        public interface IloopAttribute {}
        public interface IpreloadAttribute {}
        public interface IsrcAttribute {}
        public interface IciteAttribute {}
        public interface IheightAttribute {}
        public interface IwidthAttribute {}
        public interface IspanAttribute {}
        public interface IcheckedAttribute {}
        public interface IdisabledAttribute {}
        public interface IiconAttribute {}
        public interface IradiogroupAttribute {}
        public interface ItypeAttribute {}
        public interface IdatetimeAttribute {}
        public interface IopenAttribute {}
        public interface IformAttribute {}
        public interface InameAttribute {}
        public interface IacceptAttribute {}
        public interface Iaccept_charsetAttribute {}
        public interface IactionAttribute {}
        public interface IautocompleteAttribute {}
        public interface IenctypeAttribute {}
        public interface ImethodAttribute {}
        public interface InovalidateAttribute {}
        public interface ImanifestAttribute {}
        public interface IsandboxAttribute {}
        public interface IseamlessAttribute {}
        public interface IsrcdocAttribute {}
        public interface IismapAttribute {}
        public interface IusemapAttribute {}
        public interface IautofocusAttribute {}
        public interface IdirnameAttribute {}
        public interface IlistAttribute {}
        public interface ImaxAttribute {}
        public interface ImaxlengthAttribute {}
        public interface IminAttribute {}
        public interface ImultipleAttribute {}
        public interface IpatternAttribute {}
        public interface IplaceholderAttribute {}
        public interface IreadonlyAttribute {}
        public interface IrequiredAttribute {}
        public interface IsizeAttribute {}
        public interface IstepAttribute {}
        public interface IvalueAttribute {}
        public interface IchallengeAttribute {}
        public interface IkeytypeAttribute {}
        public interface IforAttribute {}
        public interface IsizesAttribute {}
        public interface IcharsetAttribute {}
        public interface IcontentAttribute {}
        public interface Ihttp_equivAttribute {}
        public interface IhighAttribute {}
        public interface IlowAttribute {}
        public interface IoptimumAttribute {}
        public interface IdataAttribute {}
        public interface IreversedAttribute {}
        public interface IstartAttribute {}
        public interface IselectedAttribute {}
        public interface IasyncAttribute {}
        public interface IdeferAttribute {}
        public interface IlanguageAttribute {}
        public interface IscopedAttribute {}
        public interface IsummaryAttribute {}
        public interface IcolspanAttribute {}
        public interface IheadersAttribute {}
        public interface IrowspanAttribute {}
        public interface IcolsAttribute {}
        public interface IrowsAttribute {}
        public interface IwrapAttribute {}
        public interface IscopeAttribute {}
        public interface IpubdateAttribute {}
        public interface IdefaultAttribute {}
        public interface IkindAttribute {}
        public interface IlabelAttribute {}
        public interface IsrclangAttribute {}
        public interface IposterAttribute {}
        public interface IaccesskeyAttribute {}
        public interface IclassAttribute {}
        public interface IcontenteditableAttribute {}
        public interface IcontextmenuAttribute {}
        public interface Idata_customAttribute {}
        public interface IdirAttribute {}
        public interface IdraggableAttribute {}
        public interface IdropzoneAttribute {}
        public interface IhiddenAttribute {}
        public interface IidAttribute {}
        public interface IitempropAttribute {}
        public interface IlangAttribute {}
        public interface IspellcheckAttribute {}
        public interface IstyleAttribute {}
        public interface ItabindexAttribute {}
        public interface ItitleAttribute {}

    }

}