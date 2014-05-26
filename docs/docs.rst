

`http://docutils.sourceforge.net/rst.html<http://docutils.sourceforge.net/rst.html>`_





Plain text	Typical result	Notes
*emphasis*	emphasis	Normally rendered as italics.
**strong emphasis**	strong emphasis	Normally rendered as boldface.
`interpreted text`	(see note at right)	The rendering and meaning of interpreted text is domain- or application-dependent. It can be used for things like index entries or explicit descriptive markup (like program identifiers).
``inline literal``	inline literal	Normally rendered as monospaced text. Spaces should be preserved, but line breaks will not be.
reference_	reference	A simple, one-word hyperlink reference. See Hyperlink Targets.
`phrase reference`_	phrase reference	A hyperlink reference with spaces or punctuation needs to be quoted with backquotes. See Hyperlink Targets.
anonymous__	anonymous	With two underscores instead of one, both simple and phrase references may be anonymous (the reference text is not repeated at the target). See Hyperlink Targets.
_`inline internal target`	inline internal target	A crossreference target within text. See Hyperlink Targets.
|substitution reference|	(see note at right)	The result is substituted in from the substitution definition. It could be text, an image, a hyperlink, or a combination of these and others.
footnote reference [1]_	footnote reference 1	See Footnotes.
citation reference [CIT2002]_	citation reference [CIT2002]	See Citations.
http://docutils.sf.net/	http://docutils.sf.net/	A standalone hyperlink.



Asterisk, backquote, vertical bar, and underscore are inline delimiter characters. Asterisk, backquote, and vertical bar act like quote marks; matching characters surround the marked-up word or phrase, whitespace or other quoting is required outside them, and there can't be whitespace just inside them. If you want to use inline delimiter characters literally, escape (with backslash) or quote them (with double backquotes; i.e. use inline literals).

In detail, the reStructuredText specification says that in inline markup, the following rules apply to start-strings and end-strings (inline markup delimiters):

The start-string must start a text block or be immediately preceded by whitespace or any of  ' " ( [ { or <.
The start-string must be immediately followed by non-whitespace.
The end-string must be immediately preceded by non-whitespace.
The end-string must end a text block (end of document or followed by a blank line) or be immediately followed by whitespace or any of ' " . , : ; ! ? - ) ] } / \ or >.
If a start-string is immediately preceded by one of  ' " ( [ { or <, it must not be immediately followed by the corresponding character from  ' " ) ] } or >.
An end-string must be separated by at least one character from the start-string.
An unescaped backslash preceding a start-string or end-string will disable markup recognition, except for the end-string of inline literals.
Also remember that inline markup may not be nested (well, except that inline literals can contain any of the other inline markup delimiter characters, but that doesn't count because nothing is processed).




