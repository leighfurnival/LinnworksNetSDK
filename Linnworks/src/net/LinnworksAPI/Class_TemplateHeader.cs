using System;

namespace LinnworksAPI
{
    public class TemplateHeader
    {
        public int pkTemplateRowId;
        public Guid TemplateId;
        public string TemplateType;
        public string TemplateName;
        public bool Enabled;
        public bool IsDefault;
        public bool IsEmailAttachment;
        public string VisibilityCondition;
        public bool bLogicalDelete;
        public bool IsConditional;
        public int ConditionRating;
    }
}