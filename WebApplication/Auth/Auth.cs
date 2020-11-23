using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Encryption;
using System.Xml;
using System.IO;

namespace WebApplication.Auth
{
    public class Auth
    {
        private string filePath;

        public Auth(string filePath)
        {
            this.filePath = filePath;
        }
        public bool MemberExists(string username)
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            xmldoc.Load(this.filePath);
            XmlNodeList memberNodes = xmldoc.GetElementsByTagName("member");
            for (int i = 0; i < memberNodes.Count; i++)
            {
                string u = memberNodes[i].ChildNodes.Item(0).InnerText.Trim();
                if (username == u)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Login(string username, string password)
        {
            string hash = Hasher.hash(password);
            bool success = false;
            XmlDataDocument xmldoc = new XmlDataDocument();
            xmldoc.Load(this.filePath);
            XmlNodeList memberNodes = xmldoc.GetElementsByTagName("member");
            for (int i = 0; i < memberNodes.Count; i++)
            {
                string u = memberNodes[i].ChildNodes.Item(0).InnerText.Trim();
                string h = memberNodes[i].ChildNodes.Item(1).InnerText.Trim();
                if (username == u && hash == h)
                {
                    success = true;
                    break;
                }
            }
            return success;
        }

        public bool Register(string username, string password, string group)
        {
            if (this.MemberExists(username))
            {
                return false;
            }
            string hash = Hasher.hash(password);
            XmlDataDocument xmldoc = new XmlDataDocument();
            xmldoc.Load(this.filePath);
            XmlNode usernameNode = xmldoc.CreateNode(XmlNodeType.Element, "username", null);
            usernameNode.InnerText = username;
            XmlNode passwordNode = xmldoc.CreateNode(XmlNodeType.Element, "hash", null);
            passwordNode.InnerText = hash;
            XmlNode groupNode = xmldoc.CreateNode(XmlNodeType.Element, "group", null);
            groupNode.InnerText = group;
            XmlNode memberNode = xmldoc.CreateNode(XmlNodeType.Element, "member", null);
            memberNode.AppendChild(usernameNode);
            memberNode.AppendChild(passwordNode);
            memberNode.AppendChild(groupNode);
            XmlNode memberRoot = xmldoc.SelectSingleNode("members", null);
            memberRoot.AppendChild(memberNode);
            xmldoc.Save(this.filePath);
            return true;

        }

        public string GetRole(string username)
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            xmldoc.Load(this.filePath);
            XmlNodeList memberNodes = xmldoc.GetElementsByTagName("member");
            for (int i = 0; i < memberNodes.Count; i++)
            {
                string u = memberNodes[i].ChildNodes.Item(0).InnerText.Trim();
                string group = memberNodes[i].ChildNodes.Item(2).InnerText.Trim();
                if (username == u)
                {
                    return group;
                }
            }
            return "None";
        }
    }
}
