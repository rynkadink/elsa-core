﻿namespace Elsa.Client.Models
{
    public enum WorkflowContextFidelity
    {
        /// <summary>
        /// The workflow context is loaded only once per burst of execution.
        /// </summary>
        Burst,
        
        /// <summary>
        /// The workflow context is loaded before executing an activity.
        /// </summary>
        Activity
    }
}