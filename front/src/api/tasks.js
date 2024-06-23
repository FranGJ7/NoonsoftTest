import axios from 'axios';

const api = axios.create({
  baseURL: 'http://localhost:5214'
});

export const getAllTasks = () => api.get('/tasks');
export const addTask = (task) => api.post('/task', task);
export const deleteTaskById = (id) => api.delete(`/task/${id}`);
export const updateTask = (task) => api.put('/task', task);
