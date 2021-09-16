using System;
using System.Collections.Generic;
using Godot;
using GoDoTest.Core.Spec;
using GoDoTest.Matchers;
using static GoDoTest.Core.Spec.Scopes.FunSpecRootContext;
using static GoDoTest.Matchers.StringMatcher;

namespace GoDoTest.godot {
  public class Runner : TestRunner {
    /// <summary>
    ///   Called when the node enters the scene tree for the first time.
    /// </summary>
    public override void _Ready() {
      var _ = new FunSpec(() => {
        Test("length should return size of string", () => "hello".Length.ShouldBe(5));
        Test("startsWith should test for a prefix", () => "world".ShouldMatch(StartWith("wor")));
      });
      base._Ready();
    }
  }

  public class TestRunner : Node {

    public override void _Ready() {
      
    }
  }
}