using SalezNoAuthTest1.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalezNoAuthTest1.Models
{

    public class Workspace
    {
        private WatsonContext context;

        [Key]
        public int IdWorkspace { get; set; }

        public string Workspace_id { get; set; }
        public string Name { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }

        //public Metadata Metadata { get; set; }
        public string Metadata { get; set; }

        public List<IntentTable> Intents { get; set; }
        public List<EntityTable> Entities { get; set; }
        public List<DialogNodeTable> Dialog_nodes { get; set; }
        //public List<object> Counterexamples { get; set; }
    }

    public class Metadata
    {
        public string Runtime_version { get; set; }
    }

    public class EntityTable
    {
        [Key]
        public int IdEntityTable { get; set; }

        public string Entity { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }

        //public Metadata Metadata { get; set; }
        public string Metadata { get; set; }

        //public object Description { get; set; }

        public List<ValueTable> Values { get; set; }
    }

    public class ValueTable
    {
        [Key]
        public int IdValueTable { get; set; }

        public string Value { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }

        //public Metadata Metadata { get; set; }
        public string Metadata { get; set; }

        public List<SynonymTable> Synonyms { get; set; }
    }

    public class SynonymTable
    {
        [Key]
        public int IdSynonymTable { get; set; }

        public string Created { get; set; }
        public string Synonym { get; set; }
        public string Updated { get; set; }
    }


    public class IntentTable
    {
        [Key]
        public int IdIntentTable { get; set; }

        public string Intent { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }

        //public object Description { get; set; }
        public string Description { get; set; }

        public List<Example> Examples { get; set; }
    }

    public class Example
    {
        [Key]
        public int IdExample { get; set; }

        public string Text { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }
    }

    public class DialogNodeTable
    {
        [Key]
        public int IdDialogNodeTable { get; set; }

        public string Title { get; set; }
        public string Parent { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }
        public string Conditions { get; set; }
        public string Dialog_node { get; set; }
        public string Previous_sibling { get; set; }
        public string Type { get; set; }

        //public object Metadata { get; set; }
        public string Metadata { get; set; }

        //public object Description { get; set; }
        public string Description { get; set; }

        public Output Output { get; set; }

        //public object Context { get; set; }

        public NextStep Next_step { get; set; }
    }

    public class Output
    {
        [Key]
        public int IdOutput { get; set; }

        public Text Text { get; set; }
    }

    public class Text
    {
        [Key]
        public int IdText { get; set; }

        //public List<object> Values { get; set; }
        public string Values { get; set; }
        public string Selection_policy { get; set; }
    }


    public class NextStep
    {
        [Key]
        public int IdNextStep { get; set; }

        public string Behavior { get; set; }
        public string Selector { get; set; }
        public string Dialog_node { get; set; }
    }
}
