﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

public class CommandClass
{
    public string Name { get; set; }

    public void NotCommandMethod()
    {
    }

    [OnCommand("TestCommand")]
    public void OnTestCommand()
    {
    }

    [OnCommand("TestCommand2")]
    public void OnTestCommand2()
    {
        
    }
}

public class CommandClassWithInitializer
{
    public CommandClassWithInitializer()
    {
        this.InitializeCommands();
    }

    private void InitializeCommands()
    {
        if (TestCommand == null)
        {
            TestCommand = new DelegateCommand(OnTestCommand);
        }

        if (SubmitCommand == null)
        {
            SubmitCommand = new DelegateCommand(OnSubmit);
        }
    }

    public ICommand TestCommand { get; set; }
    public ICommand SubmitCommand { get; set; }
    
    public void OnTestCommand()
    {        
    }

    public void OnSubmit()
    {        
    }
}