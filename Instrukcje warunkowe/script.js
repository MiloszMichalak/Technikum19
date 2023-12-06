<?xml version="1.0" encoding="utf-8"?>
<manifest xmlns:android="http://schemas.android.com/apk/res/android"
    package="com.example.todoapp.test" >

    <uses-sdk
        android:minSdkVersion="33"
        android:targetSdkVersion="34" />

    <instrumentation
        android:name="androidx.test.runner.AndroidJUnitRunner"
        android:functionalTest="false"
        android:handleProfiling="false"
        android:label="Tests for com.example.todoapp"
        android:targetPackage="com.example.todoapp" />

    <uses-permission android:name="android.permission.REORDER_TASKS" />

    <queries>
        <package android:name="androidx.test.orchestrator" />
        <package android:name="androidx.test.services" />
        <package android:name="com.google.android.apps.common.testing.services" />
    </queries>

    <application
        android:debuggable="true"
        android:extractNativeLibs="false" >
        <uses-library android:name="android.test.runner" />

        <activity
            android:name="androidx.test.core.app.InstrumentationActivityInvoker$BootstrapActivity"
            android:exported="true"
            android:theme="@style/WhiteBackgroundTheme" >
            <intent-filter android:priority="-100" >
                <category android:name="android.intent.category.LAUNCHER" />
            </intent-filter>
        </activity>
        <activity
            android:name=