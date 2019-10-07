
using System;
using System.Text.RegularExpressions;

namespace Alg1.Practica.Practicum5
{
    public class XmlValidator
    {
        public bool Validate(string xml)
        {
            Stack tagOrder = new Stack();

            var allTags = Regex.Matches(xml, @"<(.*?)>");

            foreach (var _tag in allTags)
            {
                String tag = _tag.ToString();

                if (tag[1] != '/')
                {
                    tagOrder.Push(tag);
                } else
                {
                    String openingTag = tagOrder.Pop();

                    if (openingTag == null || openingTag.Remove(0, 1) != tag.Remove(0, 2))
                    {
                        return false;
                    }
                }
            }

            return tagOrder.IsEmpty();
        }
    }
}


