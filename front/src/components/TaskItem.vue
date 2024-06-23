<template>
    <div class="card w-96 bg-base-100 shadow-xl">
      <div class="card-body">
        <div class="card-actions justify-end">
          <button class="btn btn-square btn-outline btn-xs btn-error" @click="onDelete(task.id)">
            <svg xmlns="http://www.w3.org/2000/svg" class="h-6 w-6" fill="none" viewBox="0 0 24 24" stroke="currentColor">
              <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M6 18L18 6M6 6l12 12" />
            </svg>
          </button>
        </div>
  
        <div class="flex items-center space-x-3">
          <input class="checkbox checkbox-success mr-3" @change="onToggleStatus(task)" type="checkbox" v-model="task.done">
          <form v-if="task.isEditing" @submit.prevent="onSave(task)" class="flex items-center">
            <input maxlength="40" type="text" class="input input-bordered w-full max-w-xs" v-model="task.name" required>
            <button class="btn btn-outline ml-2">Save</button>
          </form>
          <p v-else>{{ task.name }}</p>
        </div>
  
        <div class="card-actions justify-end">
          <button class="btn btn-square btn-outline btn-xs" @click="task.isEditing = !task.isEditing">
            <svg viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
              <path d="M9 5H7C5.89543 5 5 5.89543 5 7V19C5 20.1046 5.89543 21 7 21H9M15 5H17C18.1046 5 19 5.89543 19 7V9" stroke="#ffffff" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"></path>
              <path d="M14.902 20.3343L12.7153 20.7716L13.1526 18.585C13.1914 18.3914 13.2865 18.2136 13.4261 18.074L17.5 14L19.5 12L21.4869 13.9869L19.4869 15.9869L15.413 20.0608C15.2734 20.2004 15.0956 20.2956 14.902 20.3343Z" stroke="#ffffff" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"></path>
              <path d="M9 5C9 3.89543 9.89543 3 11 3H13C14.1046 3 15 3.89543 15 5V7H9V5Z" stroke="#ffffff" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"></path>
            </svg>
          </button>
        </div>
      </div>
    </div>
  </template>
  
  <script setup>
  defineProps({
    task: Object,
    onDelete: Function,
    onSave: Function,
    onToggleStatus: Function
  });
  </script>
  