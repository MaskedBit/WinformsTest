
Public Class UserFunctionReader

    Public Property UserFunctions As New UserFunction

    ' TODO:  The user settings should be read from the UserFunction.xml file.
    ' TODO:  Since that's not critical to the Forms at the moment, the data is built in code.
    Public Sub New(ByRef path As String)
        Dim productionUser As New UserOptions
        With productionUser
            .ID = "production"
            .Name = "Production User"
        End With

        Dim setupUser As New UserOptions
        With setupUser
            .ID = "setup"
            .Name = "Setup User"
        End With

        Dim admin1User As New UserOptions
        With admin1User
            .ID = "admin1"
            .Name = "John Super Doe"
        End With

        Dim production1User As New UserOptions
        With production1User
            .ID = "production1"
            .Name = "John Doe"
        End With

        Dim prodManualMode As New MenuOptions
        With prodManualMode
            .ID = "manualMode"
            .Name = "Manual Mode"
            .MainMenuUIElement = ""
            .IconFile = ""
            .FormName = "Manual Mode"
        End With

        Dim adminManualMode As New MenuOptions
        With prodManualMode
            .ID = "manualMode"
            .Name = "Manual Mode"
            .MainMenuUIElement = ""
            .IconFile = ""
            .FormName = "Manual Mode"
        End With

        Dim pinCheck As New TabOptions
        With pinCheck
            .ID = "pinCheck"
            .Name = "Pin Check"
            .UIElement = "ucProductionManualModePinCheck"
        End With
        prodManualMode.TabOptions.Add(pinCheck)
        adminManualMode.TabOptions.Add(pinCheck)

        Dim homeCalibration As New TabOptions
        With homeCalibration
            .ID = "homeCalibration"
            .Name = "Home / Calibration"
            .UIElement = "ucProductionManualModeHomeCalibration"
        End With
        prodManualMode.TabOptions.Add(homeCalibration)
        adminManualMode.TabOptions.Add(homeCalibration)

        Dim jbCalibration As New TabOptions
        With jbCalibration
            .ID = "jbCalibration"
            .Name = "Junction Box Calibration"
            .UIElement = "ucProductionManualModeJbCalibration"
        End With
        prodManualMode.TabOptions.Add(jbCalibration)
        adminManualMode.TabOptions.Add(jbCalibration)

        Dim screwCalibration As New TabOptions
        With screwCalibration
            .ID = "screwCalibration"
            .Name = "Screw Position Calibration"
            .UIElement = "ucProductionManualModeSpCalibration"
        End With
        prodManualMode.TabOptions.Add(screwCalibration)
        adminManualMode.TabOptions.Add(screwCalibration)

        Dim firmwareUpdate As New TabOptions
        With firmwareUpdate
            .ID = "firmwareUpdate"
            .Name = "Firmware Update"
            .UIElement = "ucProductionManualModeJbCalibration"
        End With
        adminManualMode.TabOptions.Add(firmwareUpdate)

        Dim automaticMode As New MenuOptions
        With automaticMode
            .ID = "automaticMode"
            .Name = "Automatic Mode"
            .MainMenuUIElement = ""
            .IconFile = ""
            .FormName = "Recipes"
        End With

        Dim selectRecipe As New TabOptions
        With selectRecipe
            .ID = "selectRecipe"
            .Name = "Select Recipe"
            .UIElement = "ucSetupRecipesManagement"
        End With
        automaticMode.TabOptions.Add(selectRecipe)

        Dim pinStatus As New TabOptions
        With pinStatus
            .ID = "pinStatus"
            .Name = "Pin Status"
            .UIElement = "ucSetupRecipesMoldMap"
        End With
        automaticMode.TabOptions.Add(pinStatus)

        Dim lotCounter As New TabOptions
        With lotCounter
            .ID = "lotCounter"
            .Name = "Production Lot"
            .UIElement = "ucProductionRunModeLotCounter"
        End With
        automaticMode.TabOptions.Add(lotCounter)

        Dim sequenceOverview As New TabOptions
        With sequenceOverview
            .ID = "sequenceOverview"
            .Name = "Sequence Overview"
            .UIElement = "ucSetupRecipesDDOverviewContainer"
        End With
        automaticMode.TabOptions.Add(sequenceOverview)

        Dim plots As New TabOptions
        With plots
            .ID = "plots"
            .Name = "Plots"
            .UIElement = "ucProductionRunModePlots"
        End With
        automaticMode.TabOptions.Add(plots)

        Dim signals As New TabOptions
        With signals
            .ID = "signals"
            .Name = "Interface Signals"
            .UIElement = "ucProductionRunModeIo"
        End With
        automaticMode.TabOptions.Add(signals)

        Dim recipes As New MenuOptions
        With recipes
            .ID = "recipes"
            .Name = "Recipes"
            .MainMenuUIElement = ""
            .IconFile = ""
            .FormName = "Recipes"
        End With

        Dim newRecall As New TabOptions
        With newRecall
            .ID = "newRecall"
            .Name = "New / Recall"
            .UIElement = "ucSetupRecipesManagement"
        End With
        recipes.TabOptions.Add(newRecall)

        Dim moldMap As New TabOptions
        With moldMap
            .ID = "moldMap"
            .Name = "Mold Map"
            .UIElement = "ucSetupRecipesMoldMap"
        End With
        recipes.TabOptions.Add(moldMap)

        recipes.TabOptions.Add(sequenceOverview)

        Dim sequenceEditor As New TabOptions
        With sequenceEditor
            .ID = "sequenceEditor"
            .Name = "Sequence Editor"
            .UIElement = "ucSetupRecipesDragAndDropEditor"
        End With
        recipes.TabOptions.Add(sequenceEditor)

        recipes.TabOptions.Add(plots)

        recipes.TabOptions.Add(signals)

        Dim systemSettings As New MenuOptions
        With SystemSettings
            .ID = "systemSettings"
            .Name = "Settings"
            .MainMenuUIElement = ""
            .IconFile = ""
            .FormName = "System Settings"
        End With

        Dim systemOptions As New TabOptions
        With systemOptions
            .ID = "systemOptions"
            .Name = "System Options"
            .UIElement = "ucSystemOptions"
        End With
        systemSettings.TabOptions.Add(systemOptions)

        Dim user As New TabOptions
        With user
            .ID = "user"
            .Name = "User"
            .UIElement = "ucSettingsUsers"
        End With
        systemSettings.TabOptions.Add(user)

        Dim language As New TabOptions
        With language
            .ID = "language"
            .Name = "Language"
            .UIElement = "ucSettingsLanguage"
        End With
        systemSettings.TabOptions.Add(language)

        productionUser.MenuOptions.Add(prodManualMode)
        productionUser.MenuOptions.Add(automaticMode)
        setupUser.MenuOptions.Add(adminManualMode)
        setupUser.MenuOptions.Add(recipes)
        setupUser.MenuOptions.Add(systemSettings)
        admin1User.MenuOptions.Add(adminManualMode)
        admin1User.MenuOptions.Add(recipes)
        admin1User.MenuOptions.Add(systemSettings)
        production1User.MenuOptions.Add(prodManualMode)
        production1User.MenuOptions.Add(automaticMode)

        UserFunctions.UserOptions.Add(productionUser)
        UserFunctions.UserOptions.Add(setupUser)
        UserFunctions.UserOptions.Add(admin1User)
        UserFunctions.UserOptions.Add(production1User)
    End Sub

End Class
