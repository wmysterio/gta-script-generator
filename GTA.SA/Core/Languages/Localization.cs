namespace GTA.Core.Languages {

    internal abstract class Localization {

        internal static string WordError = "";

        #region GXT
        internal static void PrintGXTAddedKey( string key ) { Debug.White( string.Format( gxt_key_added_format, key ) ); }
        internal static void PrintSaveFXT() { Debug.White( start_save_fxt ); }
        internal static string GXTNonEncoding() { return gxt_non_encoding_format; }
        internal static string GXTBadKeyName( string key ) { return string.Format( gxt_bad_key_name_format, key ); }
        internal static string GXTExistKey( string key ) { return string.Format( gxt_exist_key_format, key ); }
        internal static string GXTEncodingNotChars( string className ) { return string.Format( gxt_encoding_not_chars_format, className ); }
        internal static string GXTEncodingNonEqualsLength( string className ) { return string.Format( gxt_encoding_non_equal_lenght_format, className ); }
        internal static string GXTIncorrectFXTFileName( string fileName ) { return string.Format( gxt_incorrect_fxt_file_name, fileName ); }
        #endregion

        #region GENERATOR
        internal static void PrintStartGenerator() { Debug.Green( start_generator ); }
        internal static void PrintSaveScriptCode() { Debug.Green( start_save_script_code ); }
        internal static void PrintScriptStart( string scriptName ) { Debug.Yellow( string.Format( script_start_format, scriptName ) ); }
        internal static void PrintScriptEnd( string scriptName ) { Debug.Yellow( string.Format( script_end_format, scriptName ) ); }
        internal static void PrintGeneratorDone( double time ) { Debug.Green( string.Format( generator_done_format, time ) ); }
        internal static void PrintThrowInfo( string fileName, string methodName, int row, int column ) { System.Console.WriteLine( throw_error_info_format, fileName, methodName, row, column ); }
        internal static void PrintTempFileDeleted( string fileName ) { Debug.Green( string.Format( temp_file_deleted_format, fileName ) ); }
        internal static void PrintFolderNotFound( string fileName ) { Debug.Error( string.Format( folder_not_found_format, fileName ) ); }
        internal static void PrintFolderAndSANNYNotFound( string fileName ) { Debug.Error( string.Format( folder_and_sanny_not_found_format, fileName ) ); }
        internal static void PrintStartCompile() { Debug.Green( start_compile ); }
        internal static void PrintStartSannyBuilder() { Debug.Green( start_sanny_builder ); }
        internal static void PrintCompilengDone() { Debug.Green( compiling_done ); }
        internal static string SannyCompileError( string fileName ) { return string.Format( sanny_compile_error_format, fileName ); }
        internal static string FileNotFound( string fileName ) { return string.Format( file_not_found_format, fileName ); }
        internal static void PrintScriptIMGNotReplaced() { Debug.Blue( script_img_not_replaced ); }
        #endregion

        #region THREAD, MISSIONS, EXTERNALS, FUNCTIONS
        internal static string ThreadMAINNotFound() { return thread_main_not_found_format; }
        internal static string BadThreadNameLenght( string scriptName ) { return string.Format( bad_thread_name_length_format, scriptName ); }
        internal static string BadThreadName( string scriptName ) { return string.Format( bad_thread_name_format, scriptName ); }
        internal static string BadFunctionName( string scriptName ) { return string.Format( bad_function_name_format, scriptName ); }
        internal static string ThreadNotFound( string scriptName ) { return string.Format( thread_not_found_format, scriptName ); }
        internal static string MissionNotFound( string scriptName ) { return string.Format( mission_not_found_format, scriptName ); }
        internal static string ExternalNotFound( string scriptName ) { return string.Format( external_not_found_format, scriptName ); }
        internal static string OverflowMissionsCount() { return overflow_missions; }
        internal static string OverflowExternalsCount() { return overflow_externals; }
        internal static string JumpTableNotHandler() { return jump_table_not_handler_format; }
        internal static string JumpTableNoneCases() { return jump_table_none_cases_format; }
        internal static string JumpTableOverflowCases() { return jump_table_overflow_cases_format; }
        internal static string SwitchExistCaseValue( uint caseValue ) { return string.Format( switch_exist_case_value_format, caseValue ); }
        #endregion

        #region VARIABLES, PARAMETERS, LABELS
        internal static string VariableWithoutContext( string varName ) { return string.Format( variable_without_context_format, varName ); }
        internal static string VariableUnsupportType( string varName ) { return string.Format( variable_unsupport_type_format, varName ); }
        internal static string VariablesWithoutContext( string varName1, string varName2 ) { return string.Format( variables_without_context_format, varName1, varName2 ); }
        internal static string VariableIsNonParametr( string varName ) { return string.Format( variable_is_not_parameter_format, varName ); }
        internal static string VariableOverflowSize( string varName ) { return string.Format( variable_overflow_size_format, varName ); }
        internal static string StringIncorrectIndex( string varName, string index ) { return string.Format( string_incorrect_index, varName, index ); }
        internal static string IncorrectSStringLenght( string str ) { return string.Format( incorrect_sstring_lenght_format, str ); }
        internal static string ParametersCountIsZero( string methodName ) { return string.Format( parameters_count_is_zero_format, methodName ); }
        internal static string ParametersOverflowCount( string methodName, int count ) { return string.Format( parameters_overflow_count_format, methodName, count ); }
        internal static string LabelMemoryNotFound( string labelName ) { return string.Format( label_memory_not_found_format, labelName ); }
        internal static string LabelNotExist( string methodName ) { return string.Format( label_not_exist_format, methodName ); }
        internal static string UseVariableAsStaticOnly( string variableName ) { return string.Format( use_variable_as_static_only, variableName ); }
        #endregion

        #region PANELS
        internal static string PanelIncorrectRowsCount( string varName ) { return string.Format( panel_incorrect_rows_count_format, varName ); }
        internal static string PanelArrayDimenstionNot2( string arrayName ) { return string.Format( panel_array_dimenstion_not_2_format, arrayName ); }
        internal static string PanelRowsLow1( string arrayName ) { return string.Format( panel_rows_low_1_format, arrayName ); }
        internal static string PanelRowsGreat12( string arrayName ) { return string.Format( panel_rows_great_12_format, arrayName ); }
        internal static string PanelNeedArray() { return panel_need_array_format; }
        internal static string PanelElementCountMustBeFrom1To12( string varName ) { return string.Format( panel_element_count_must_be_from_1_to_12_format, varName ); }
        #endregion

        #region ARRAYS
        internal static string MaxIndexOfArrayOverflow( int maxIndex ) { return string.Format( max_index_of_array_overflow_format, maxIndex ); }
        internal static string MinIndexOfArrayMustBe() { return min_index_of_array_must_be_format; }
        internal static string ArrayElementCountOverflow() { return min_index_of_array_must_be_format; }
        internal static string DontUseArrayElementAsArrayIndex( string variableName ) { return string.Format( dont_use_array_element_as_array_index_format, variableName ); }
        internal static string ArrayElementMustBeGlobalWithType( string variableName, string typeName ) { return string.Format( array_element_must_be_global_with_type, variableName, typeName ); }
        internal static string ArrayElementCreatedOnlyInAutoinitialize() { return string.Format( array_element_created_only_in_autoinitialize ); }
        internal static string ArrayIndexesHave32And33() { return array_indexes_have_32_and_33; }
        #endregion

        #region LIMITS
        internal static string BadBit() { return bad_bit_format; }
        internal static string BitsWorkInSAGame() { return bits_work_in_sa_game_format; }
        internal static string MethodUsedInMissionOnly( string methodName ) { return string.Format( method_used_in_mission_only_format, methodName ); }
        internal static string UseTypeInSAGameOnly( string varName ) { return string.Format( use_type_in_sa_game_only_format, varName ); }
        internal static string CarParkVehicleNotParking( string varName ) { return string.Format( car_park_vehicle_not_parking, varName ); }
        internal static string ConditionsCountIsZero() { return conditions_count_is_zero_format; }
        internal static string ConditionsOverflowCount() { return conditions_overflow_count_format; }
        internal static string CarParkMaxCountOverflow( ushort count ) { return string.Format( car_park_count_overflow, count ); }
        internal static string LoopForLowStep() { return loop_for_step_low_format; }
        internal static string LoopForParameterMustBeGreat( string varName1, string varName2 ) { return string.Format( loop_for_parameter_must_be_great_format, varName1, varName2 ); }
        #endregion

        #region PLUGINS
        internal static string PluginMustBeOnce( string pluginName ) { return string.Format( plugin_must_be_once_format, pluginName ); }
        internal static string PluginCreatedInNonThread( string pluginName ) { return string.Format( plugin_created_in_non_thread_format, pluginName ); }
        internal static string PluginCreatedInMainTrhead( string pluginName ) { return string.Format( plugin_created_in_main_trhead_format, pluginName ); }
        internal static string PluginMustCreatedInMainTrhead( string pluginName ) { return string.Format( plugin_must_created_in_main_trhead_format, pluginName ); }
        internal static string PluginIncorrectParamsMethod( string methodName, string pluginName ) { return string.Format( plugin_incorrect_params_method_format, methodName, pluginName ); }
        internal static string PluginOverflowAudiotracks( string methodName, string pluginName ) { return string.Format( plugin_overflow_audiotracks_format, methodName, pluginName ); }
        internal static string PluginCreatedInNonMission( string pluginName ) { return string.Format( plugin_created_in_non_mission_format, pluginName ); }
        internal static string PluginCreatedInCustomMission( string pluginName ) { return string.Format( plugin_created_in_custom_mission_format, pluginName ); }
        internal static string PluginOverflowCarsCount( string pluginName, int maxCarsCount ) { return string.Format( plugin_overflow_cars_count_format, pluginName, maxCarsCount ); }
        internal static string PluginNeedMinCarCount( string pluginName, int minCarsCount ) { return string.Format( plugin_need_min_cars_count_format, pluginName, minCarsCount ); }
        internal static string PluginNeedPlayerCar( string pluginName ) { return string.Format( plugin_need_player_car_format, pluginName ); }
        internal static string PluginNeedPointsFrom1To99( string pluginName ) { return string.Format( plugin_need_points_from_1_to_99_format, pluginName ); }
        internal static string PluginLapsCountFrom2To99( string pluginName ) { return string.Format( plugin_laps_count_from_2_to_99_format, pluginName ); }
        internal static string PluginNeedPointsFrom2To99( string pluginName ) { return string.Format( plugin_need_points_from_2_to_99_format, pluginName ); }
        internal static string PluginNotHaveMissions( string pluginName ) { return string.Format( plugin_not_have_missions_format, pluginName ); }
        internal static string PluginIncorrectHandler( string pluginName, string handlerName ) { return string.Format( plugin_incorrect_andler, pluginName, handlerName ); }
        internal static string PluginPhoneNotHaveDialog( string pluginName ) { return string.Format( plugin_phone_not_have_dialog, pluginName ); }
        internal static string PluginHaveRingID( string pluginName, ushort id ) { return string.Format( plugin_have_ring_id, pluginName, id ); }
        internal static string PluginCellphoneReplicasOverflow( string pluginName, ushort id, ushort maxReplicsCount ) { return string.Format( plugin_cellphone_replicas_overflow, pluginName, id, maxReplicsCount ); }
        internal static string PluginNotHaveRingID( string pluginName, ushort id ) { return string.Format( plugin_not_have_ring_id, pluginName, id ); }
        internal static string PluginOverflowCountOfPropertiesOrZero( string pluginName, ushort maxPropertiesCount ) { return string.Format( plugin_overflow_count_of_properties_or_zero, pluginName, maxPropertiesCount ); }
        internal static string PluginPriceOfPropertiesMustBeGreatZero( string pluginName ) { return string.Format( plugin_price_of_properties_must_be_great_zero, pluginName ); }
        internal static string PluginNeedSetCameraPositionInProperty( string pluginName ) { return string.Format( plugin_need_set_camera_position_in_property, pluginName ); }
        internal static string PluginOverflowCountOfSavePointsOrZero( string pluginName, ushort maxSavePointCount ) { return string.Format( plugin_overflow_count_of_save_points_or_zero, pluginName, maxSavePointCount ); }
        internal static string PluginNeedDefaultModeInProperiesAndSaveGame( string pluginName1, string pluginName2 ) { return string.Format( plugin_need_default_mode_in_properies_and_save_game, pluginName1, pluginName2 ); }
        internal static string PluginCalculatorHasIncorrectExpression( string pluginName, string methodName ) { return string.Format( plugin_calculator_has_incorrect_expression, pluginName, methodName ); }

        // ...
        #endregion

        #region FIELDS
        protected static string car_park_vehicle_not_parking;
        protected static string start_generator;
        protected static string thread_main_not_found_format;
        protected static string overflow_missions;
        protected static string overflow_externals;
        protected static string generator_done_format;
        protected static string throw_error_info_format;
        protected static string temp_file_deleted_format;
        protected static string folder_not_found_format;
        protected static string folder_and_sanny_not_found_format;
        protected static string start_compile;
        protected static string start_sanny_builder;
        protected static string compiling_done;
        protected static string sanny_compile_error_format;
        protected static string file_not_found_format;
        protected static string script_img_not_replaced;
        protected static string bad_thread_name_length_format;
        protected static string bad_thread_name_format;
        protected static string bad_function_name_format;
        protected static string script_start_format;
        protected static string script_end_format;
        protected static string car_park_count_overflow;
        protected static string gxt_non_encoding_format;
        protected static string gxt_bad_key_name_format;
        protected static string gxt_exist_key_format;
        protected static string gxt_key_added_format;
        protected static string gxt_encoding_not_chars_format;
        protected static string gxt_encoding_non_equal_lenght_format;
        protected static string gxt_incorrect_fxt_file_name;
        protected static string variable_is_not_parameter_format;
        protected static string variable_overflow_size_format;
        protected static string variable_unsupport_type_format;
        protected static string variables_without_context_format;
        protected static string variable_without_context_format;
        protected static string string_incorrect_index;
        protected static string mission_not_found_format;
        protected static string thread_not_found_format;
        protected static string conditions_overflow_count_format;
        protected static string loop_for_step_low_format;
        protected static string loop_for_parameter_must_be_great_format;
        protected static string conditions_count_is_zero_format;
        protected static string label_memory_not_found_format;
        protected static string method_used_in_mission_only_format;
        protected static string parameters_count_is_zero_format;
        protected static string parameters_overflow_count_format;
        protected static string bits_work_in_sa_game_format;
        protected static string label_not_exist_format;
        protected static string max_index_of_array_overflow_format;
        protected static string min_index_of_array_must_be_format;
        protected static string array_element_count_overflow_format;
        protected static string array_element_must_be_global_with_type;
        protected static string array_element_created_only_in_autoinitialize;
        protected static string array_indexes_have_32_and_33;
        protected static string panel_incorrect_rows_count_format;
        protected static string panel_array_dimenstion_not_2_format;
        protected static string panel_rows_low_1_format;
        protected static string panel_rows_great_12_format;
        protected static string panel_need_array_format;
        protected static string panel_element_count_must_be_from_1_to_12_format;
        protected static string use_type_in_sa_game_only_format;
        protected static string incorrect_sstring_lenght_format;
        protected static string external_not_found_format;
        protected static string bad_bit_format;
        protected static string dont_use_array_element_as_array_index_format;
        protected static string jump_table_not_handler_format;
        protected static string jump_table_none_cases_format;
        protected static string jump_table_overflow_cases_format;
        protected static string switch_exist_case_value_format;
        protected static string start_save_fxt;
        protected static string start_save_script_code;
        protected static string use_variable_as_static_only;
        protected static string plugin_must_be_once_format;
        protected static string plugin_created_in_non_thread_format;
        protected static string plugin_created_in_main_trhead_format;
        protected static string plugin_must_created_in_main_trhead_format;
        protected static string plugin_incorrect_params_method_format;
        protected static string plugin_overflow_audiotracks_format;
        protected static string plugin_created_in_non_mission_format;
        protected static string plugin_created_in_custom_mission_format;
        protected static string plugin_overflow_cars_count_format;
        protected static string plugin_need_min_cars_count_format;
        protected static string plugin_need_player_car_format;
        protected static string plugin_need_points_from_1_to_99_format;
        protected static string plugin_laps_count_from_2_to_99_format;
        protected static string plugin_need_points_from_2_to_99_format;
        protected static string plugin_not_have_missions_format;
        protected static string plugin_incorrect_andler;
        protected static string plugin_phone_not_have_dialog;
        protected static string plugin_have_ring_id;
        protected static string plugin_cellphone_replicas_overflow;
        protected static string plugin_not_have_ring_id;
        protected static string plugin_overflow_count_of_properties_or_zero;
        protected static string plugin_price_of_properties_must_be_great_zero;
        protected static string plugin_need_set_camera_position_in_property;
        protected static string plugin_overflow_count_of_save_points_or_zero;
        protected static string plugin_need_default_mode_in_properies_and_save_game;
        protected static string plugin_calculator_has_incorrect_expression;
        #endregion

        internal Localization() { }

    }

}