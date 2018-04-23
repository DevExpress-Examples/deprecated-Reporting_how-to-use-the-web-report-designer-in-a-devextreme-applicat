// NOTE object below must be a valid JSON
window.FrontendDevExtremeProject = $.extend(true, window.FrontendDevExtremeProject, {
  "config": {
    "layoutSet": "navbar",
    "navigation": [
      {
        "title": "Home",
        "onExecute": "#home",
        "icon": "home"
      },
      {
        "title": "About",
        "onExecute": "#about",
        "icon": "info"
      },
      {
        "title": "Report Designer",
        "onExecute": "#reportDesigner",
        "icon": "reportdesigner"
      }
    ]
  }
});