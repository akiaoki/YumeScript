﻿using YumeScript.Script;

namespace YumeScript.External;

public interface IInstructionEvaluator
{
    public Task Evaluate(RuntimeInstruction instruction);
}