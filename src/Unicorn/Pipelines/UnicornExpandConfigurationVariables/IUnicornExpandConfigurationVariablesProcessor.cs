﻿using Unicorn.Pipelines.UnicornReserializeComplete;

namespace Unicorn.Pipelines.UnicornExpandConfigurationVariables
{
	public interface IUnicornExpandConfigurationVariablesProcessor
	{
		void Process(UnicornExpandConfigurationVariablesPipelineArgs args);
	}
}
