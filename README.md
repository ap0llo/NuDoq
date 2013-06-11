NuDoc: A .NET XML API Documentation Reader
===

A standalone API to read .NET XML documentation files and optionally augment it with reflection information.

NuDoc provides a simple and intuitive API that reads .NET XML documentation files into an in-memory model that can be easily used to generate alternative representations or arbitrary processing. If the read operation is performed using a .NET assembly rather than an XML file, NuDoc will automatically add the reflection information to the in-memory model for the documentation elements, making it very easy to post-process them by grouping by type, namespace, etc.

NuDoc leverages two well-known patterns: the [Visitor](http://en.wikipedia.org/wiki/Visitor_pattern) pattern and the [Composite](http://en.wikipedia.org/wiki/Composite_pattern) pattern. Essentially, every member in the documentation file is represented as a separate "visitable" type. By simply writing a NuDoc **Visitor**-derived class, you can process only the elements you're interested in.

This is a sample visitor that generates markdown content from member summaries:

        public class MarkdownVisitor : Visitor
        {
            public override void VisitMember(Member member)
            {
                Console.WriteLine();
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("# " + member.Id);
                base.VisitMember(member);
            }

            public override void VisitSummary(Summary summary)
            {
                Console.WriteLine();
                Console.WriteLine("## Summary");
                base.VisitSummary(summary);
            }

            public override void VisitRemarks(Remarks remarks)
            {
                Console.WriteLine();
                Console.WriteLine("## Remarks");
                base.VisitRemarks(remarks);
            }

            public override void VisitExample(Example example)
            {
                Console.WriteLine();
                Console.WriteLine("### Example");
                base.VisitExample(example);
            }

            public override void VisitC(C code)
            {
                // Wrap inline code in ` according to Markdown syntax.
                Console.Write(" `");
                Console.Write(code.Content);
                Console.Write("` ");

                base.VisitC(code);
            }

            public override void VisitCode(Code code)
            {
                Console.WriteLine();
                Console.WriteLine();
                
                // Indent code with 4 spaces according to Markdown syntax.
                foreach (var line in code.Content.Split(new[] { Environment.NewLine }, StringSplitOptions.None))
                {
                    Console.Write("    ");
                    Console.WriteLine(line);
                }

                Console.WriteLine();
                base.VisitCode(code);
            }

            public override void VisitText(Text text)
            {
                Console.Write(text.Content);
                base.VisitText(text);
            }

            public override void VisitPara(Para para)
            {
                Console.WriteLine();
                Console.WriteLine();
                base.VisitPara(para);
                Console.WriteLine();
                Console.WriteLine();
            }

            public override void VisitSee(See see)
            {
                var cref = NormalizeLink(see.Cref);
                Console.Write(" [{0}]({1}) ", cref.Substring(2), cref);
            }

            public override void VisitSeeAlso(SeeAlso seeAlso)
            {
                var cref = NormalizeLink(seeAlso.Cref);
                Console.WriteLine("[{0}]({1})", cref.Substring(2), cref);
            }

            private string NormalizeLink(string cref)
            {
                return cref.Replace(":", "-").Replace("(", "-").Replace(")", "");
            }
        }


There are two logically separated hierarchies of visitable elements: the members (like the whole set read by the **Reader**, a type, method, property, etc.) and the documentation elements (like summary, remarks, code, etc.).

The following is the members hierarchy:

![Members hierarchy](https://raw.github.com/clariuslabs/NuDoc/master/doc/NuDoc.Members.png)

And this is the support documentation elements hierarchy:

![Members hierarchy](https://raw.github.com/clariuslabs/NuDoc/master/doc/NuDoc.Content.png)