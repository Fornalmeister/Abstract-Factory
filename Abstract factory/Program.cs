// See https://aka.ms/new-console-template for more information

using Abstract_factory;
using Abstract_factory.Mac;
using Abstract_factory.Windows;

var uiApplication = new Application(new MacFactory());

uiApplication.RenderUI();