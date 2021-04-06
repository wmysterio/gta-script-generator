namespace GTA.Core.Languages {
    internal sealed class Locale_EN : Localization {
        internal Locale_EN() : base() {
            WordError = "Error";

            #region GXT
            start_save_fxt = "Saving the FXT archives...";
            gxt_non_encoding_format = "The encoding not set!";
            gxt_bad_key_name_format = "Incorrect GXT-key '{0}'!";
            gxt_exist_key_format = "GXT-key '{0}' has been added before!";
            gxt_key_added_format = "GXT-key '{0}' added...";
            gxt_encoding_not_chars_format = "No conversion characters specified in class '{0}'!";
            gxt_encoding_non_equal_lenght_format = "Class '{0}' has a different character set!";
            gxt_incorrect_fxt_file_name = "Invalid FXT file name '{0}'!";
            #endregion

            #region GENERATOR
            start_generator = "Generator started...";
            start_save_script_code = "Saving the script code...";
            script_start_format = "[{0}] Start...";
            script_end_format = "[{0}] Finish...";
            generator_done_format = "Done! Work duration {0} s.";
            throw_error_info_format = "\nFile: {0}\nMethod: {1}\nLine: {2}\nColumn: {3}";
            temp_file_deleted_format = "Temporary file '{0}' deleted...";
            folder_not_found_format = "Folder '{0}' is not defined!";
            folder_and_sanny_not_found_format = "Folder for '{0}' is not defined!";
            start_compile = "Compiling started...";
            start_sanny_builder = "Sanny Builder started...";
            compiling_done = "Compiling done!";
            sanny_compile_error_format = "Compilation error! See the information in the file '{0}' in the root of the project.";
            file_not_found_format = "File '{0}' not found!";
            script_img_not_replaced = "Failed to overwrite file 'script.img'! You need exit from game to completely before compiling.";
            #endregion

            #region THREAD, MISSIONS, EXTERNALS, FUNCTIONS
            thread_main_not_found_format = "Thread 'MAIN' undefined!";
            bad_thread_name_length_format = "The script name '{0}' must be between 1 and 7 characters!";
            bad_thread_name_format = "Invalid script name '{0}'! Use only latin characters, numbers and the _!";
            bad_function_name_format = "Invalid function name '{0}'! Use only latin characters, numbers and the _!";
            thread_not_found_format = "Thread '{0}' not found!";
            mission_not_found_format = "Mission '{0}' not found!";
            external_not_found_format = "External script '{0}' not found!";
            overflow_missions = "The limit on the number of missions exceeded! Maximum quantity: 200 for SA or 120 for III and VC!";
            overflow_externals = "The limit on the number of external scripts exceeded! Maximum number: 82!";
            jump_table_not_handler_format = "The jump table does not have a handler!";
            jump_table_none_cases_format = "Jump table must have at least 1 label!";
            jump_table_overflow_cases_format = "The jump table must have a maximum of 74 labels!";
            switch_exist_case_value_format = "The value '{0}' already exists in the jump table!";
            #endregion

            #region VARIABLES, PARAMETERS, LABELS
            variable_without_context_format = "The variable '{0}' must have a context!";
            variable_unsupport_type_format = "Variable type '{0}' is not supported for this operation!";
            variables_without_context_format = "Variables '{0}' and '{1}' without context!";
            variable_is_not_parameter_format = "The variable '{0}' cannot be a parameter!";
            variable_overflow_size_format = "Variable '{0}' takes up more space than allowed!";
            string_incorrect_index = "Variable '{0}' cannot use index '{1}'!";
            incorrect_sstring_lenght_format = "The string length '{0}' must be up to 7 characters inclusive!";
            parameters_count_is_zero_format = "The number of parameters for the method '{0}' must be greater than 0!";
            parameters_overflow_count_format = "The maximum number of parameters for the method '{0}' must be {1}!";
            label_memory_not_found_format = "The label '{0}' not found!";
            label_not_exist_format = "The label not exist in method '{0}'!";
            use_variable_as_static_only = "The global variable '{0}' must be declared with the 'static' modifier!";
            #endregion

            #region PANELS
            panel_incorrect_rows_count_format = "The panel '{0}' must have from 1 to 12 rows inclusive!";
            panel_array_dimenstion_not_2_format = "Array '{0}' must be two-dimensional!";
            panel_rows_low_1_format = "The number of rows in the array '{0}' must be greater than 1!";
            panel_rows_great_12_format = "The number of rows in the array '{0}' must be less than 13!";
            panel_need_array_format = "You must specify an array!";
            panel_element_count_must_be_from_1_to_12_format = "The number of elements in the array '{0}' must be from 1 to 12 inclusive!";
            #endregion

            #region ARRAYS
            max_index_of_array_overflow_format = "Maximum array index: {0}!";
            min_index_of_array_must_be_format = "Minimum number of array elements: 1!";
            array_element_count_overflow_format = "Exceeded the number of elements in the array or its initial index does not allow you to create more elements!";
            dont_use_array_element_as_array_index_format = "The variable '{0}' cannot be used as an array index!";
            array_element_must_be_global_with_type = "Array '{0}' of type '{1}' must be global!";
            array_element_created_only_in_autoinitialize = $"Array must be initialized as a class field!";
            array_indexes_have_32_and_33 = "Array elements cannot use the variables 32@ and 33@. Please enter the correct index!";
            #endregion

            #region LIMITS
            bad_bit_format = "The number bit must be between 0 and 31 inclusive!";
            bits_work_in_sa_game_format = "Bits work in GTA SA only!";
            method_used_in_mission_only_format = "The method '{0}' can only be used in missions!";
            use_type_in_sa_game_only_format = "Type '{0}' can only be used in GTA SA!";
            car_park_vehicle_not_parking = "Vehicle '{0}' is not parking!";
            conditions_count_is_zero_format = "The number of conditions must be greater than 0!";
            conditions_overflow_count_format = "The number of conditions must be from 1 to 8!";
            car_park_count_overflow = "The maximum number of vehicles in the parking lot is {0}!";
            loop_for_step_low_format = "The loop step must be greater than 0!";
            loop_for_parameter_must_be_great_format = "The loop parameter '{0}' must be greater than the parameter '{1}'!";
            #endregion

            #region PLUGINS
            plugin_must_be_once_format = "The plugin '{0}' should be created only once!";
            plugin_created_in_non_thread_format = "The plugin '{0}' must be created in the stream!";
            plugin_created_in_main_trhead_format = "The plugin '{0}' should not be created in the stream 'MAIN'!";
            plugin_must_created_in_main_trhead_format = "The plugin '{0}' must be created in the thread 'MAIN'!";
            plugin_incorrect_params_method_format = "Incorrect parameters in method '{0}' of plugin '{1}'!";
            plugin_overflow_audiotracks_format = "Method '{0}' of plugin '{1}' no longer has sounds to play!";
            plugin_created_in_non_mission_format = "The plugin '{0}' must be created in the mission!";
            plugin_created_in_custom_mission_format = "The plugin '{0}' cannot be created in custom missions!";
            plugin_overflow_cars_count_format = "In the plugin '{0}' the maximum number of cars must be {1}!";
            plugin_need_min_cars_count_format = "In the plugin '{0}' the minimum number of cars must be {1}!";
            plugin_need_player_car_format = "The plugin '{0}' must have a player car!";
            plugin_need_points_from_1_to_99_format = "The plugin '{0}' must have from 1 to 99 points!";
            plugin_laps_count_from_2_to_99_format = "The plugin '{0}' must have from 2 to 99 circles!";
            plugin_need_points_from_2_to_99_format = "The plugin '{0}' must have from 2 to 99 points!";
            plugin_not_have_missions_format = "There are no missions to run in the plugin '{0}'!";
            plugin_incorrect_andler = "In the plugin '{0}', the handler '{1}' is not defined!";
            plugin_phone_not_have_dialog = "The count of calls in plugin '{0}' must be greeted by 0!";
            plugin_have_ring_id = "The plugin '{0}' already been added call with ID '{1}'!";
            plugin_cellphone_replicas_overflow = "The number of replicas in the plugin '{0}' with the call ID '{1}' exceeds '{2}' pieces, or equals 0!";
            plugin_not_have_ring_id = "The plugin '{0}' not been added call with ID '{1}'!";
            plugin_overflow_count_of_properties_or_zero = "In the plugin '{0}', the number of properties exceeds '{1}' or equal to 0";
            plugin_price_of_properties_must_be_great_zero = "In the plugin '{0}' the whole property must be greater than 0!";
            plugin_need_set_camera_position_in_property = "In the plugin '{0}' the camera position is not set!";
            plugin_overflow_count_of_save_points_or_zero = "In the plugin '{0}' the number of points exceeds '{1}' or equal to 0!";
            plugin_need_default_mode_in_properies_and_save_game = "The plugin '{0}' does not have a link to the plugin '{1}' or its settings are arbitrary!";
            plugin_calculator_has_incorrect_expression = "In '{0}' plugin, '{1}' method has incorrect expression format!";
            #endregion

        }
    }
}