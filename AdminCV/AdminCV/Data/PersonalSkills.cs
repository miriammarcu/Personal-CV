//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminCV.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonalSkills
    {
        public int ID_PersonalSkill { get; set; }
        public int SkillCategory_ID { get; set; }
        public string Description { get; set; }
    
        public virtual SkillCategory SkillCategory { get; set; }
    }
}
